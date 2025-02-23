using System;
using System.Collections.Generic;
using System.Text;
using System.IO.Ports;

namespace VFDUtility
{
    class VFDConnection
    {
        public delegate void DisplayBasicEvent();
        public delegate void DisplayAnnuciatorEvent(int index, int state);

        public event DisplayBasicEvent OnDisplayClear;
        public event DisplayBasicEvent OnDisplayWrite;
        public event DisplayBasicEvent OnDisplayBrightnessChange;
        public event DisplayAnnuciatorEvent OnAnnuciatorChange;

        private SerialPort serialPort;

        public VFDConnection(SerialPort serialPort)
        {
            this.serialPort = serialPort;
        }

        public void clearDisplay()
        {
            this.serialPort.Write(new byte[] { 0x0C }, 0, 1);

            if (this.OnDisplayClear != null)
            {
                this.OnDisplayClear.Invoke();
            }
        }

        public void writeString(string text)
        {
            this.serialPort.Write(text);

            if (this.OnDisplayWrite != null)
            {
                this.OnDisplayWrite.Invoke();
            }
        }

        public void setPosition(int row, int column)
        {
            if (row > 2 || row == 0)
            {
                throw new Exception("Rows out of bounds");
            }

            if (column > 20 || column == 0)
            {
                throw new Exception("Columns out of bounds");
            }

            byte rowByte = Byte.Parse(row.ToString());
            byte columnByte = Byte.Parse(column.ToString());

            this.serialPort.Write(new byte[] { 0x1F, 0x24, columnByte, rowByte }, 0, 4);
        }

        public void setBrightness(int level)
        {
            if (level > 4 || level == 0)
            {
                throw new Exception("Brightness level out of bounds");
            }

            byte brightnessByte = Byte.Parse(level.ToString());

            this.serialPort.Write(new byte[] { 0x1F, 0x58, brightnessByte }, 0, 3);

            if (this.OnDisplayBrightnessChange != null)
            {
                this.OnDisplayBrightnessChange.Invoke();
            }
        }

        public void selfTest()
        {
            this.serialPort.Write(new byte[] { 0x1F, 0x40 }, 0, 2);
        }

        public void setAnnunciator(int index, int state)
        {
            byte indexByte = Byte.Parse(index.ToString());
            byte stateByte = Byte.Parse(state.ToString());

            this.serialPort.Write(new byte[] { 0x1F, 0x23, stateByte, indexByte }, 0, 4);

            if (this.OnAnnuciatorChange != null)
            {
                this.OnAnnuciatorChange.Invoke(index, state);
            }
        }
    }
}
