using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testing_Environ_Project
{
    public partial class GNSS_DataConversion : Form
    {
        public GNSS_DataConversion()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HELLO WORLD!");
        }

		private static byte[] hex2dec_table = new byte[23]
		{
			0,
			1,
			2,
			3,
			4,
			5,
			6,
			7,
			8,
			9,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			10,
			11,
			12,
			13,
			14,
			15
		};
		private byte[] CAN_byte = new byte[8];

		private void DecodeCANmessage(byte[] CANmessage)
		{
			byte b = 0;
			byte b2 = 0;
			int pgn = 0;
			byte b3 = 0;
			int num2 = 0;
			uint num3 = 0u;
			if (CANmessage.Length < 26 || CANmessage[0] == 116 || CANmessage[0] != 84 || CANmessage[9] != 56)
			{
				MessageBox.Show("I'm Here");
				return;
			}
			try
			{
				pgn = ((hex2dec_table[CANmessage[2] - 48] & 3) << 16) + (hex2dec_table[CANmessage[3] - 48] << 12) + (hex2dec_table[CANmessage[4] - 48] << 8) + (hex2dec_table[CANmessage[5] - 48] << 4) + hex2dec_table[CANmessage[6] - 48];
				b2 = (byte)((hex2dec_table[CANmessage[5] - 48] << 4) + hex2dec_table[CANmessage[6] - 48]);
				b3 = (byte)(((hex2dec_table[CANmessage[1] - 48] & 1) << 2) + ((hex2dec_table[CANmessage[2] - 48] & 0xC) >> 2));
				b = (byte)((hex2dec_table[CANmessage[7] - 48] << 4) + hex2dec_table[CANmessage[8] - 48]);
				num2 = hex2dec_table[CANmessage[9] - 48];
				int num4 = 0;
				int num5 = 0;
				while (num4 < num2 * 2)
				{
					CAN_byte[num5] = (byte)((hex2dec_table[CANmessage[10 + num4] - 48] << 4) + hex2dec_table[CANmessage[11 + num4] - 48]);
					num4 += 2;
					num5++;
				}
				num3 = (uint)((hex2dec_table[CANmessage[26] - 48] << 12) + (hex2dec_table[CANmessage[27] - 48] << 8) + (hex2dec_table[CANmessage[28] - 48] << 4) + hex2dec_table[CANmessage[29] - 48]);



				if (pgn >= 59392 && pgn < 60672)
				{
					pgn &= 0xFF00;
				}

				if(pgn_Output.Text == "_")
				{
					pgn_Output.Text = pgn.ToString();
				}
				else
				{
					pgn_Output.Text += " , " + pgn.ToString();
				}

				switch (pgn)
				{
					case 126992:
						{
							byte b15 = CAN_byte[0];
							byte b16 = (byte)(CAN_byte[1] & 0xF);
							ushort num24 = (ushort)(CAN_byte[3] * 256 + CAN_byte[2]);
							double num25 = (double)(uint)((CAN_byte[7] << 24) + (CAN_byte[6] << 16) + (CAN_byte[5] << 8) + CAN_byte[4]) / 10000.0;
							double value = (double)(int)num24 * 86400.0 + num25;
							DateTime dateTime = new DateTime(1970, 1, 1).AddSeconds(value);
							time_Output.Text = dateTime.ToString("yyyy/MM/dd HH:mm:ss.ff");
							break;
						}
					case 65304:
						{
							byte b8 = CAN_byte[0];
							double num14 = (double)(int)CAN_byte[1] * 0.005;
							double num15 = (double)(long)(((ulong)CAN_byte[4] << 16) + ((ulong)CAN_byte[3] << 8) + CAN_byte[2]) / 100.0;
							byte b9 = CAN_byte[5];
							byte b10 = CAN_byte[6];
							byte b11 = CAN_byte[7];

							altitude_Output.Text = $"{num15:f2}";

							break;
						}
					case 65305:
						{
							byte b30 = CAN_byte[0];
							double num54 = (double)(int)CAN_byte[1] * 0.005;
							double latitude = (double)(long)(((ulong)CAN_byte[7] << 40) + ((ulong)CAN_byte[6] << 32) + ((ulong)CAN_byte[5] << 24) + ((ulong)CAN_byte[4] << 16) + ((ulong)CAN_byte[3] << 8) + CAN_byte[2]) / 100000000000.0;
							latitude_Output.Text = latitude.ToString();
							break;
						}
					case 65306:
						{
							byte b28 = CAN_byte[0];
							double num50 = (double)(int)CAN_byte[1] * 0.005;
							double longitude = (double)(long)(((ulong)CAN_byte[7] << 40) + ((ulong)CAN_byte[6] << 32) + ((ulong)CAN_byte[5] << 24) + ((ulong)CAN_byte[4] << 16) + ((ulong)CAN_byte[3] << 8) + CAN_byte[2]) / 100000000000.0;
							longitude_Output.Text = longitude.ToString();
							break;
						}
					case 127257:
						{
							byte b31 = CAN_byte[0];
							double num56 = (double)(short)(CAN_byte[2] * 256 + CAN_byte[1]) / 10000.0;
							double num57 = (double)(short)(CAN_byte[4] * 256 + CAN_byte[3]) / 10000.0;
							double num58 = (double)(short)(CAN_byte[6] * 256 + CAN_byte[5]) / 10000.0;
							double num59 = num56 * 180.0 / Math.PI;
							double num60 = num57 * 180.0 / Math.PI;
							double num61 = num58 * 180.0 / Math.PI;

							String yaw = $"{num59:f4}";
							String pitch = $"{num60:f4}";
							String roll = $"{num61:f4}";

							yaw_Output.Text = yaw + " Rad";
							pitch_Output.Text = pitch + " Rad";
							roll_Output.Text = roll + " Rad";

							break;
						}
				}

			}
			catch (Exception e)
			{
				MessageBox.Show(e.ToString());
				return;
			}



		}

		private void start_Btn_Click(object sender, EventArgs e)
		{
			string[] inputs = input_Box.Text.TrimEnd().Split(
								new[] { Environment.NewLine },
								StringSplitOptions.None
							);
			for(int i=0; i < inputs.Length; i++)
			{
				byte[] input = Encoding.ASCII.GetBytes(inputs[i]);
				DecodeCANmessage(input);
			}



		}

		private void clear_Btn_Click(object sender, EventArgs e)
		{
			input_Box.Clear();
			pgn_Output.Text = "_";
			time_Output.Text = "_";
			altitude_Output.Text = "_";
			longitude_Output.Text = "_";
			latitude_Output.Text = "_";
		}

		private void GNSS_DataConversion_FormClosed(object sender, FormClosedEventArgs e)
		{
			FormProvider.getMain().Show();
		}
	}
}
