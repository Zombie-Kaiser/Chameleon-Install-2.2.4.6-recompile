using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Chameleon_Install.Properties;
using Microsoft.Win32;

namespace Chameleon_Install;

public class Form1 : Form
{
	private IContainer components;

	private PictureBox pictureBox1;

	private ComboBox comboBox1;

	private Label label1;

	private Button button1;

	private TextBox textBox1;

	private Label label2;

	private LinkLabel linkLabel1;

	private LinkLabel linkLabel2;

	private LinkLabel linkLabel3;

	private LinkLabel linkLabel4;

	private LinkLabel linkLabel5;

	private PictureBox pictureBox2;

	private Label label3;

	private LinkLabel linkLabel6;

	private PictureBox pictureBox3;

	private RadioButton radioButton1;

	private RadioButton radioButton2;

	private ComboBox comboBox2;

	private PictureBox pictureBox4;

	private LinkLabel linkLabel7;

	private Label label5;

	private LinkLabel linkLabel8;

	private LinkLabel linkLabel9;

	private Button button2;

	private LinkLabel linkLabel10;

	private Button button3;

	private LinkLabel linkLabel11;

	private ImageList imageList1;

	private LinkLabel linkLabel12;

	public Form1()
	{
		InitializeComponent();
	}

	private void processStart(string CMDName, string runstring)
	{
		Process process = new Process();
		process.StartInfo.CreateNoWindow = true;
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.RedirectStandardInput = true;
		process.StartInfo.RedirectStandardOutput = true;
		process.StartInfo.RedirectStandardError = true;
		process.StartInfo.FileName = CMDName;
		process.StartInfo.Arguments = runstring;
		process.Start();
		StreamReader standardOutput = process.StandardOutput;
		textBox1.Text = standardOutput.ReadToEnd();
	}

	private void addtext(string path2, string text1)
	{
		FileStream fileStream = null;
		StreamWriter streamWriter = null;
		File.SetAttributes(path2, FileAttributes.Normal);
		string input = File.ReadAllText(path2);
		Regex regex = new Regex("C:\\\\Avldr.bin=Chameleon");
		Match match = regex.Match(input);
		if (!match.Success)
		{
			fileStream = new FileStream(path2, FileMode.Append, FileAccess.Write);
			streamWriter = new StreamWriter(fileStream, Encoding.Default);
			streamWriter.WriteLine("\r\n");
			streamWriter.Write(text1);
			streamWriter.Flush();
			streamWriter.Close();
			fileStream.Close();
			File.SetAttributes(path2, FileAttributes.ReadOnly | FileAttributes.Hidden);
		}
	}

	private void FSfiles(string themewowpc, string driverphat)
	{
		if (themewowpc == "Default")
		{
			byte[] rc5default = Resources.rc5default;
			FileStream fileStream = new FileStream(driverphat + "wowpc.iso", FileMode.Create);
			BinaryWriter binaryWriter = new BinaryWriter(fileStream);
			binaryWriter.Write(rc5default, 0, rc5default.Length);
			binaryWriter.Close();
			fileStream.Close();
			byte[] avldr = Resources.Avldr;
			FileStream output = new FileStream(driverphat + "Avldr.bin", FileMode.Create);
			BinaryWriter binaryWriter2 = new BinaryWriter(output);
			binaryWriter2.Write(avldr, 0, avldr.Length);
			binaryWriter2.Close();
			fileStream.Close();
			byte[] avlgo = Resources.Avlgo;
			FileStream output2 = new FileStream(driverphat + "Avlgo.sys", FileMode.Create);
			BinaryWriter binaryWriter3 = new BinaryWriter(output2);
			binaryWriter3.Write(avlgo, 0, avlgo.Length);
			binaryWriter3.Close();
			fileStream.Close();
			File.SetAttributes(driverphat + "wowpc.iso", FileAttributes.ReadOnly | FileAttributes.Hidden);
			File.SetAttributes(driverphat + "Avldr.bin", FileAttributes.ReadOnly | FileAttributes.Hidden);
			File.SetAttributes(driverphat + "Avlgo.sys", FileAttributes.ReadOnly | FileAttributes.Hidden);
		}
		if (themewowpc == "wowpc")
		{
			byte[] rc5wowpc = Resources.rc5wowpc;
			FileStream fileStream2 = new FileStream(driverphat + "wowpc.iso", FileMode.Create);
			BinaryWriter binaryWriter4 = new BinaryWriter(fileStream2);
			binaryWriter4.Write(rc5wowpc, 0, rc5wowpc.Length);
			binaryWriter4.Close();
			fileStream2.Close();
			byte[] avldr2 = Resources.Avldr;
			FileStream output3 = new FileStream(driverphat + "Avldr.bin", FileMode.Create);
			BinaryWriter binaryWriter5 = new BinaryWriter(output3);
			binaryWriter5.Write(avldr2, 0, avldr2.Length);
			binaryWriter5.Close();
			fileStream2.Close();
			byte[] avlgo2 = Resources.Avlgo;
			FileStream output4 = new FileStream(driverphat + "Avlgo.sys", FileMode.Create);
			BinaryWriter binaryWriter6 = new BinaryWriter(output4);
			binaryWriter6.Write(avlgo2, 0, avlgo2.Length);
			binaryWriter6.Close();
			fileStream2.Close();
			File.SetAttributes(driverphat + "wowpc.iso", FileAttributes.ReadOnly | FileAttributes.Hidden);
			File.SetAttributes(driverphat + "Avldr.bin", FileAttributes.ReadOnly | FileAttributes.Hidden);
			File.SetAttributes(driverphat + "Avlgo.sys", FileAttributes.ReadOnly | FileAttributes.Hidden);
		}
		if (themewowpc == "iphone")
		{
			byte[] rc5iphone = Resources.rc5iphone;
			FileStream fileStream3 = new FileStream(driverphat + "wowpc.iso", FileMode.Create);
			BinaryWriter binaryWriter7 = new BinaryWriter(fileStream3);
			binaryWriter7.Write(rc5iphone, 0, rc5iphone.Length);
			binaryWriter7.Close();
			fileStream3.Close();
			byte[] avldr3 = Resources.Avldr;
			FileStream output5 = new FileStream(driverphat + "Avldr.bin", FileMode.Create);
			BinaryWriter binaryWriter8 = new BinaryWriter(output5);
			binaryWriter8.Write(avldr3, 0, avldr3.Length);
			binaryWriter8.Close();
			fileStream3.Close();
			byte[] avlgo3 = Resources.Avlgo;
			FileStream output6 = new FileStream(driverphat + "Avlgo.sys", FileMode.Create);
			BinaryWriter binaryWriter9 = new BinaryWriter(output6);
			binaryWriter9.Write(avlgo3, 0, avlgo3.Length);
			binaryWriter9.Close();
			fileStream3.Close();
			File.SetAttributes(driverphat + "wowpc.iso", FileAttributes.ReadOnly | FileAttributes.Hidden);
			File.SetAttributes(driverphat + "Avldr.bin", FileAttributes.ReadOnly | FileAttributes.Hidden);
			File.SetAttributes(driverphat + "Avlgo.sys", FileAttributes.ReadOnly | FileAttributes.Hidden);
		}
		if (themewowpc == "mint")
		{
			byte[] rc5mint = Resources.rc5mint;
			FileStream fileStream4 = new FileStream(driverphat + "wowpc.iso", FileMode.Create);
			BinaryWriter binaryWriter10 = new BinaryWriter(fileStream4);
			binaryWriter10.Write(rc5mint, 0, rc5mint.Length);
			binaryWriter10.Close();
			fileStream4.Close();
			byte[] avldr4 = Resources.Avldr;
			FileStream output7 = new FileStream(driverphat + "Avldr.bin", FileMode.Create);
			BinaryWriter binaryWriter11 = new BinaryWriter(output7);
			binaryWriter11.Write(avldr4, 0, avldr4.Length);
			binaryWriter11.Close();
			fileStream4.Close();
			byte[] avlgo4 = Resources.Avlgo;
			FileStream output8 = new FileStream(driverphat + "Avlgo.sys", FileMode.Create);
			BinaryWriter binaryWriter12 = new BinaryWriter(output8);
			binaryWriter12.Write(avlgo4, 0, avlgo4.Length);
			binaryWriter12.Close();
			fileStream4.Close();
			File.SetAttributes(driverphat + "wowpc.iso", FileAttributes.ReadOnly | FileAttributes.Hidden);
			File.SetAttributes(driverphat + "Avldr.bin", FileAttributes.ReadOnly | FileAttributes.Hidden);
			File.SetAttributes(driverphat + "Avlgo.sys", FileAttributes.ReadOnly | FileAttributes.Hidden);
		}
		if (themewowpc == "Bootcamp")
		{
			byte[] rc5Bootcamp = Resources.rc5Bootcamp;
			FileStream fileStream5 = new FileStream(driverphat + "wowpc.iso", FileMode.Create);
			BinaryWriter binaryWriter13 = new BinaryWriter(fileStream5);
			binaryWriter13.Write(rc5Bootcamp, 0, rc5Bootcamp.Length);
			binaryWriter13.Close();
			fileStream5.Close();
			byte[] avldr5 = Resources.Avldr;
			FileStream output9 = new FileStream(driverphat + "Avldr.bin", FileMode.Create);
			BinaryWriter binaryWriter14 = new BinaryWriter(output9);
			binaryWriter14.Write(avldr5, 0, avldr5.Length);
			binaryWriter14.Close();
			fileStream5.Close();
			byte[] avlgo5 = Resources.Avlgo;
			FileStream output10 = new FileStream(driverphat + "Avlgo.sys", FileMode.Create);
			BinaryWriter binaryWriter15 = new BinaryWriter(output10);
			binaryWriter15.Write(avlgo5, 0, avlgo5.Length);
			binaryWriter15.Close();
			fileStream5.Close();
			File.SetAttributes(driverphat + "wowpc.iso", FileAttributes.ReadOnly | FileAttributes.Hidden);
			File.SetAttributes(driverphat + "Avldr.bin", FileAttributes.ReadOnly | FileAttributes.Hidden);
			File.SetAttributes(driverphat + "Avlgo.sys", FileAttributes.ReadOnly | FileAttributes.Hidden);
		}
		if (themewowpc == "Chamatic")
		{
			byte[] rc5Chamatic = Resources.rc5Chamatic;
			FileStream fileStream6 = new FileStream(driverphat + "wowpc.iso", FileMode.Create);
			BinaryWriter binaryWriter16 = new BinaryWriter(fileStream6);
			binaryWriter16.Write(rc5Chamatic, 0, rc5Chamatic.Length);
			binaryWriter16.Close();
			fileStream6.Close();
			byte[] avldr6 = Resources.Avldr;
			FileStream output11 = new FileStream(driverphat + "Avldr.bin", FileMode.Create);
			BinaryWriter binaryWriter17 = new BinaryWriter(output11);
			binaryWriter17.Write(avldr6, 0, avldr6.Length);
			binaryWriter17.Close();
			fileStream6.Close();
			byte[] avlgo6 = Resources.Avlgo;
			FileStream output12 = new FileStream(driverphat + "Avlgo.sys", FileMode.Create);
			BinaryWriter binaryWriter18 = new BinaryWriter(output12);
			binaryWriter18.Write(avlgo6, 0, avlgo6.Length);
			binaryWriter18.Close();
			fileStream6.Close();
			File.SetAttributes(driverphat + "wowpc.iso", FileAttributes.ReadOnly | FileAttributes.Hidden);
			File.SetAttributes(driverphat + "Avldr.bin", FileAttributes.ReadOnly | FileAttributes.Hidden);
			File.SetAttributes(driverphat + "Avlgo.sys", FileAttributes.ReadOnly | FileAttributes.Hidden);
		}
		if (themewowpc == "bullet")
		{
			byte[] rc5bullet = Resources.rc5bullet;
			FileStream fileStream7 = new FileStream(driverphat + "wowpc.iso", FileMode.Create);
			BinaryWriter binaryWriter19 = new BinaryWriter(fileStream7);
			binaryWriter19.Write(rc5bullet, 0, rc5bullet.Length);
			binaryWriter19.Close();
			fileStream7.Close();
			byte[] avldr7 = Resources.Avldr;
			FileStream output13 = new FileStream(driverphat + "Avldr.bin", FileMode.Create);
			BinaryWriter binaryWriter20 = new BinaryWriter(output13);
			binaryWriter20.Write(avldr7, 0, avldr7.Length);
			binaryWriter20.Close();
			fileStream7.Close();
			byte[] avlgo7 = Resources.Avlgo;
			FileStream output14 = new FileStream(driverphat + "Avlgo.sys", FileMode.Create);
			BinaryWriter binaryWriter21 = new BinaryWriter(output14);
			binaryWriter21.Write(avlgo7, 0, avlgo7.Length);
			binaryWriter21.Close();
			fileStream7.Close();
			File.SetAttributes(driverphat + "wowpc.iso", FileAttributes.ReadOnly | FileAttributes.Hidden);
			File.SetAttributes(driverphat + "Avldr.bin", FileAttributes.ReadOnly | FileAttributes.Hidden);
			File.SetAttributes(driverphat + "Avlgo.sys", FileAttributes.ReadOnly | FileAttributes.Hidden);
		}
		if (themewowpc == "Mountain Lion")
		{
			byte[] rc5lion = Resources.rc5lion;
			FileStream fileStream8 = new FileStream(driverphat + "wowpc.iso", FileMode.Create);
			BinaryWriter binaryWriter22 = new BinaryWriter(fileStream8);
			binaryWriter22.Write(rc5lion, 0, rc5lion.Length);
			binaryWriter22.Close();
			fileStream8.Close();
			byte[] avldr8 = Resources.Avldr;
			FileStream output15 = new FileStream(driverphat + "Avldr.bin", FileMode.Create);
			BinaryWriter binaryWriter23 = new BinaryWriter(output15);
			binaryWriter23.Write(avldr8, 0, avldr8.Length);
			binaryWriter23.Close();
			fileStream8.Close();
			byte[] avlgo8 = Resources.Avlgo;
			FileStream output16 = new FileStream(driverphat + "Avlgo.sys", FileMode.Create);
			BinaryWriter binaryWriter24 = new BinaryWriter(output16);
			binaryWriter24.Write(avlgo8, 0, avlgo8.Length);
			binaryWriter24.Close();
			fileStream8.Close();
			File.SetAttributes(driverphat + "wowpc.iso", FileAttributes.ReadOnly | FileAttributes.Hidden);
			File.SetAttributes(driverphat + "Avldr.bin", FileAttributes.ReadOnly | FileAttributes.Hidden);
			File.SetAttributes(driverphat + "Avlgo.sys", FileAttributes.ReadOnly | FileAttributes.Hidden);
		}
		if (themewowpc == "Lion no Resolution.dylib")
		{
			byte[] rc5lionNo = Resources.rc5lionNo;
			FileStream fileStream9 = new FileStream(driverphat + "wowpc.iso", FileMode.Create);
			BinaryWriter binaryWriter25 = new BinaryWriter(fileStream9);
			binaryWriter25.Write(rc5lionNo, 0, rc5lionNo.Length);
			binaryWriter25.Close();
			fileStream9.Close();
			byte[] avldr9 = Resources.Avldr;
			FileStream output17 = new FileStream(driverphat + "Avldr.bin", FileMode.Create);
			BinaryWriter binaryWriter26 = new BinaryWriter(output17);
			binaryWriter26.Write(avldr9, 0, avldr9.Length);
			binaryWriter26.Close();
			fileStream9.Close();
			byte[] avlgo9 = Resources.Avlgo;
			FileStream output18 = new FileStream(driverphat + "Avlgo.sys", FileMode.Create);
			BinaryWriter binaryWriter27 = new BinaryWriter(output18);
			binaryWriter27.Write(avlgo9, 0, avlgo9.Length);
			binaryWriter27.Close();
			fileStream9.Close();
			File.SetAttributes(driverphat + "wowpc.iso", FileAttributes.ReadOnly | FileAttributes.Hidden);
			File.SetAttributes(driverphat + "Avldr.bin", FileAttributes.ReadOnly | FileAttributes.Hidden);
			File.SetAttributes(driverphat + "Avlgo.sys", FileAttributes.ReadOnly | FileAttributes.Hidden);
		}
	}

	private void FindSymantec(RegistryKey MyKey)
	{
		string[] valueNames = MyKey.GetValueNames();
		foreach (string name in valueNames)
		{
			if (MyKey.GetValueKind(name) == RegistryValueKind.String)
			{
				string text = MyKey.GetValue(name).ToString();
				if (text.Contains("Chameleon"))
				{
					textBox1.Text = MyKey.Name.Replace("HKEY_LOCAL_MACHINE\\BCD00000000\\Objects\\", "").Replace("\\Elements\\12000004", "");
				}
			}
		}
		if (MyKey.SubKeyCount == 0)
		{
			return;
		}
		string[] subKeyNames = MyKey.GetSubKeyNames();
		foreach (string name2 in subKeyNames)
		{
			RegistryKey myKey;
			try
			{
				myKey = MyKey.OpenSubKey(name2);
			}
			catch
			{
				continue;
			}
			FindSymantec(myKey);
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		button2.PerformClick();
		textBox1.Text = "";
		if (comboBox1.SelectedIndex == 0)
		{
			try
			{
				FSfiles(comboBox2.Text, "C:\\");
				addtext("C:\\Boot.ini", "C:\\Avldr.bin=Chameleon");
				textBox1.Text = "install success ~!";
			}
			catch (Exception ex)
			{
				textBox1.Text = ex.Message;
			}
		}
		if (comboBox1.SelectedIndex != 1)
		{
			return;
		}
		string[] logicalDrives = Environment.GetLogicalDrives();
		foreach (string text in logicalDrives)
		{
			if (text.StartsWith("A") || text.StartsWith("B") || !File.Exists(text.ToString() + "bootmgr") || File.Exists(text.ToString() + "Setup.exe"))
			{
				continue;
			}
			if (Directory.Exists(text.ToString() + "boot"))
			{
				try
				{
					FSfiles(comboBox2.Text, text.ToString());
					processStart("bcdedit", " /create /d \"Chameleon\" /application bootsector");
					FindSymantec(Registry.LocalMachine.OpenSubKey("BCD00000000\\Objects"));
					string text2 = textBox1.Text;
					processStart("bcdedit", " /set " + text2 + " device boot");
					processStart("bcdedit", " /set " + text2 + " path \\Avldr.bin");
					processStart("bcdedit", " /displayorder " + text2 + " /addlast");
				}
				catch (Exception ex2)
				{
					textBox1.Text = ex2.Message;
				}
			}
			else
			{
				MessageBox.Show("Add 100M hidden partition (win7 boot)! ");
			}
		}
	}

	private void button2_Click(object sender, EventArgs e)
	{
		textBox1.Text = "";
		if (comboBox1.SelectedIndex == 0)
		{
			try
			{
				FileStream fileStream = null;
				StreamWriter streamWriter = null;
				File.SetAttributes("C:\\wowpc.iso", FileAttributes.Normal);
				File.SetAttributes("C:\\Avldr.bin", FileAttributes.Normal);
				File.SetAttributes("C:\\Avlgo.sys", FileAttributes.Normal);
				File.Delete("C:\\wowpc.iso");
				File.Delete("C:\\Avldr.bin");
				File.Delete("C:\\Avlgo.sys");
				File.SetAttributes("C:\\boot.ini", FileAttributes.Normal);
				string input = File.ReadAllText("C:\\boot.ini", Encoding.Default);
				input = Regex.Replace(input, "C:\\\\Avldr.bin=Chameleon", "\r\n");
				input = Regex.Replace(input, "\\n[\\s| ]*\\r", "");
				fileStream = new FileStream("C:\\boot.ini", FileMode.Create, FileAccess.Write);
				streamWriter = new StreamWriter(fileStream, Encoding.Default);
				streamWriter.Write(input);
				streamWriter.Flush();
				streamWriter.Close();
				fileStream.Close();
				File.SetAttributes("C:\\boot.ini", FileAttributes.ReadOnly | FileAttributes.Hidden);
				textBox1.Text = "Uninstall success ~!";
			}
			catch (Exception ex)
			{
				textBox1.Text = ex.Message;
			}
		}
		if (comboBox1.SelectedIndex != 1)
		{
			return;
		}
		string[] logicalDrives = Environment.GetLogicalDrives();
		foreach (string text in logicalDrives)
		{
			if (text.StartsWith("A") || text.StartsWith("B") || !File.Exists(text.ToString() + "bootmgr") || File.Exists(text.ToString() + "Setup.exe"))
			{
				continue;
			}
			if (Directory.Exists(text.ToString() + "boot"))
			{
				FindSymantec(Registry.LocalMachine.OpenSubKey("BCD00000000\\Objects"));
				string text2 = textBox1.Text;
				processStart("bcdedit", " /delete " + text2);
				try
				{
					File.SetAttributes(text.ToString() + "wowpc.iso", FileAttributes.Normal);
					File.SetAttributes(text.ToString() + "Avldr.bin", FileAttributes.Normal);
					File.SetAttributes(text.ToString() + "Avlgo.sys", FileAttributes.Normal);
					File.Delete(text.ToString() + "wowpc.iso");
					File.Delete(text.ToString() + "Avldr.bin");
					File.Delete(text.ToString() + "Avlgo.sys");
				}
				catch (Exception ex2)
				{
					textBox1.Text = ex2.Message;
				}
			}
			else
			{
				MessageBox.Show("Add 100M hidden partition (win7 boot)! ");
			}
		}
	}

	private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("http://chameleon.osx86.hu");
	}

	private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("http://www.znpc.net/avlgo");
	}

	private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("http://wiki.osx86project.org/wiki/index.php/Main_Page");
	}

	private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("http://www.insanelymac.com");
	}

	private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("http://pcwizcomputer.com");
	}

	private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("http://www.wowpc.cn");
	}

	private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("http://forge.voodooprojects.org/p/chameleon");
	}

	private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("http://www.wowpc.cn/thread-13076-1-1.html");
	}

	private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("http://www.wowpc.cn/thread-33636-1-1.html");
	}

	private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("http://www.wowpc.cn/thread-17262-1-1.html");
	}

	private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("http://www.wowpc.cn/thread-27027-1-2.html");
	}

	private void linkLabel12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("http://www.wowpc.cn/thread-33905-1-1.html");
	}

	private void radioButton1_CheckedChanged(object sender, EventArgs e)
	{
		Controls.Clear();
		Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
		InitializeComponent();
		Form1_view();
	}

	private void radioButton2_CheckedChanged(object sender, EventArgs e)
	{
		Controls.Clear();
		Thread.CurrentThread.CurrentUICulture = new CultureInfo("zh-CN");
		InitializeComponent();
		Form1_view();
	}

	private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
	{
		pictureBox4.Image = imageList1.Images[comboBox2.SelectedIndex];
	}

	public void Form1_view()
	{
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion");
		double num = Convert.ToDouble(registryKey.GetValue("CurrentVersion"));
		if (num < 6.0)
		{
			comboBox1.SelectedIndex = 0;
		}
		if (num >= 6.0)
		{
			comboBox1.SelectedIndex = 1;
		}
		comboBox2.SelectedIndex = 0;
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		Form1_view();
	}

	private void button3_Click(object sender, EventArgs e)
	{
		Form form = new chameleon();
		form.ShowDialog();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
		this.components = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chameleon_Install.Form1));
		this.comboBox1 = new System.Windows.Forms.ComboBox();
		this.label1 = new System.Windows.Forms.Label();
		this.button1 = new System.Windows.Forms.Button();
		this.textBox1 = new System.Windows.Forms.TextBox();
		this.label2 = new System.Windows.Forms.Label();
		this.linkLabel1 = new System.Windows.Forms.LinkLabel();
		this.linkLabel2 = new System.Windows.Forms.LinkLabel();
		this.linkLabel3 = new System.Windows.Forms.LinkLabel();
		this.linkLabel4 = new System.Windows.Forms.LinkLabel();
		this.linkLabel5 = new System.Windows.Forms.LinkLabel();
		this.label3 = new System.Windows.Forms.Label();
		this.linkLabel6 = new System.Windows.Forms.LinkLabel();
		this.radioButton1 = new System.Windows.Forms.RadioButton();
		this.radioButton2 = new System.Windows.Forms.RadioButton();
		this.comboBox2 = new System.Windows.Forms.ComboBox();
		this.linkLabel7 = new System.Windows.Forms.LinkLabel();
		this.label5 = new System.Windows.Forms.Label();
		this.linkLabel8 = new System.Windows.Forms.LinkLabel();
		this.linkLabel9 = new System.Windows.Forms.LinkLabel();
		this.button2 = new System.Windows.Forms.Button();
		this.linkLabel10 = new System.Windows.Forms.LinkLabel();
		this.button3 = new System.Windows.Forms.Button();
		this.linkLabel11 = new System.Windows.Forms.LinkLabel();
		this.imageList1 = new System.Windows.Forms.ImageList(this.components);
		this.linkLabel12 = new System.Windows.Forms.LinkLabel();
		this.pictureBox4 = new System.Windows.Forms.PictureBox();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.pictureBox2 = new System.Windows.Forms.PictureBox();
		this.pictureBox3 = new System.Windows.Forms.PictureBox();
		((System.ComponentModel.ISupportInitialize)this.pictureBox4).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.pictureBox3).BeginInit();
		base.SuspendLayout();
		this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBox1.FormattingEnabled = true;
		this.comboBox1.Items.AddRange(new object[2]
		{
			resources.GetString("comboBox1.Items"),
			resources.GetString("comboBox1.Items1")
		});
		resources.ApplyResources(this.comboBox1, "comboBox1");
		this.comboBox1.Name = "comboBox1";
		resources.ApplyResources(this.label1, "label1");
		this.label1.Name = "label1";
		resources.ApplyResources(this.button1, "button1");
		this.button1.Name = "button1";
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(this.button1_Click);
		this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		resources.ApplyResources(this.textBox1, "textBox1");
		this.textBox1.Name = "textBox1";
		this.textBox1.ReadOnly = true;
		resources.ApplyResources(this.label2, "label2");
		this.label2.Name = "label2";
		resources.ApplyResources(this.linkLabel1, "linkLabel1");
		this.linkLabel1.Name = "linkLabel1";
		this.linkLabel1.TabStop = true;
		this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
		resources.ApplyResources(this.linkLabel2, "linkLabel2");
		this.linkLabel2.Name = "linkLabel2";
		this.linkLabel2.TabStop = true;
		this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
		resources.ApplyResources(this.linkLabel3, "linkLabel3");
		this.linkLabel3.Name = "linkLabel3";
		this.linkLabel3.TabStop = true;
		this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
		resources.ApplyResources(this.linkLabel4, "linkLabel4");
		this.linkLabel4.Name = "linkLabel4";
		this.linkLabel4.TabStop = true;
		this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
		resources.ApplyResources(this.linkLabel5, "linkLabel5");
		this.linkLabel5.Name = "linkLabel5";
		this.linkLabel5.TabStop = true;
		this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
		resources.ApplyResources(this.label3, "label3");
		this.label3.Name = "label3";
		resources.ApplyResources(this.linkLabel6, "linkLabel6");
		this.linkLabel6.Name = "linkLabel6";
		this.linkLabel6.TabStop = true;
		this.linkLabel6.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel6_LinkClicked);
		resources.ApplyResources(this.radioButton1, "radioButton1");
		this.radioButton1.Name = "radioButton1";
		this.radioButton1.UseVisualStyleBackColor = true;
		this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
		resources.ApplyResources(this.radioButton2, "radioButton2");
		this.radioButton2.Name = "radioButton2";
		this.radioButton2.UseVisualStyleBackColor = true;
		this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
		this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBox2.FormattingEnabled = true;
		this.comboBox2.Items.AddRange(new object[9]
		{
			resources.GetString("comboBox2.Items"),
			resources.GetString("comboBox2.Items1"),
			resources.GetString("comboBox2.Items2"),
			resources.GetString("comboBox2.Items3"),
			resources.GetString("comboBox2.Items4"),
			resources.GetString("comboBox2.Items5"),
			resources.GetString("comboBox2.Items6"),
			resources.GetString("comboBox2.Items7"),
			resources.GetString("comboBox2.Items8")
		});
		resources.ApplyResources(this.comboBox2, "comboBox2");
		this.comboBox2.Name = "comboBox2";
		this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
		resources.ApplyResources(this.linkLabel7, "linkLabel7");
		this.linkLabel7.Name = "linkLabel7";
		this.linkLabel7.TabStop = true;
		this.linkLabel7.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel7_LinkClicked);
		resources.ApplyResources(this.label5, "label5");
		this.label5.Name = "label5";
		resources.ApplyResources(this.linkLabel8, "linkLabel8");
		this.linkLabel8.LinkColor = System.Drawing.Color.Red;
		this.linkLabel8.Name = "linkLabel8";
		this.linkLabel8.TabStop = true;
		this.linkLabel8.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel8_LinkClicked);
		resources.ApplyResources(this.linkLabel9, "linkLabel9");
		this.linkLabel9.LinkColor = System.Drawing.Color.Red;
		this.linkLabel9.Name = "linkLabel9";
		this.linkLabel9.TabStop = true;
		this.linkLabel9.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel9_LinkClicked);
		resources.ApplyResources(this.button2, "button2");
		this.button2.Name = "button2";
		this.button2.UseVisualStyleBackColor = true;
		this.button2.Click += new System.EventHandler(this.button2_Click);
		resources.ApplyResources(this.linkLabel10, "linkLabel10");
		this.linkLabel10.LinkColor = System.Drawing.Color.Red;
		this.linkLabel10.Name = "linkLabel10";
		this.linkLabel10.TabStop = true;
		this.linkLabel10.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel10_LinkClicked);
		resources.ApplyResources(this.button3, "button3");
		this.button3.Name = "button3";
		this.button3.UseVisualStyleBackColor = true;
		this.button3.Click += new System.EventHandler(this.button3_Click);
		resources.ApplyResources(this.linkLabel11, "linkLabel11");
		this.linkLabel11.LinkColor = System.Drawing.Color.Red;
		this.linkLabel11.Name = "linkLabel11";
		this.linkLabel11.TabStop = true;
		this.linkLabel11.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel11_LinkClicked);
		this.imageList1.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imageList1.ImageStream");
		this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
		this.imageList1.Images.SetKeyName(0, "rc5default.png");
		this.imageList1.Images.SetKeyName(1, "rc5wowpc.png");
		this.imageList1.Images.SetKeyName(2, "rc5iphone.png");
		this.imageList1.Images.SetKeyName(3, "rc5mint.png");
		this.imageList1.Images.SetKeyName(4, "rc5Bootcamp.png");
		this.imageList1.Images.SetKeyName(5, "rc5Chamatic.png");
		this.imageList1.Images.SetKeyName(6, "rc5bullet.png");
		this.imageList1.Images.SetKeyName(7, "rc5lion.png");
		this.imageList1.Images.SetKeyName(8, "rc5lionNo.png");
		resources.ApplyResources(this.linkLabel12, "linkLabel12");
		this.linkLabel12.Name = "linkLabel12";
		this.linkLabel12.TabStop = true;
		this.linkLabel12.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel12_LinkClicked);
		resources.ApplyResources(this.pictureBox4, "pictureBox4");
		this.pictureBox4.Name = "pictureBox4";
		this.pictureBox4.TabStop = false;
		resources.ApplyResources(this.pictureBox1, "pictureBox1");
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.TabStop = false;
		resources.ApplyResources(this.pictureBox2, "pictureBox2");
		this.pictureBox2.Name = "pictureBox2";
		this.pictureBox2.TabStop = false;
		resources.ApplyResources(this.pictureBox3, "pictureBox3");
		this.pictureBox3.Name = "pictureBox3";
		this.pictureBox3.TabStop = false;
		resources.ApplyResources(this, "$this");
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.Controls.Add(this.linkLabel12);
		base.Controls.Add(this.linkLabel11);
		base.Controls.Add(this.button3);
		base.Controls.Add(this.linkLabel10);
		base.Controls.Add(this.linkLabel9);
		base.Controls.Add(this.linkLabel8);
		base.Controls.Add(this.label5);
		base.Controls.Add(this.linkLabel7);
		base.Controls.Add(this.pictureBox4);
		base.Controls.Add(this.comboBox2);
		base.Controls.Add(this.radioButton2);
		base.Controls.Add(this.radioButton1);
		base.Controls.Add(this.pictureBox3);
		base.Controls.Add(this.linkLabel6);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.button2);
		base.Controls.Add(this.pictureBox2);
		base.Controls.Add(this.linkLabel5);
		base.Controls.Add(this.linkLabel4);
		base.Controls.Add(this.linkLabel3);
		base.Controls.Add(this.linkLabel2);
		base.Controls.Add(this.linkLabel1);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.textBox1);
		base.Controls.Add(this.button1);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.comboBox1);
		base.Controls.Add(this.pictureBox1);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "Form1";
		base.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
		base.Load += new System.EventHandler(this.Form1_Load);
		((System.ComponentModel.ISupportInitialize)this.pictureBox4).EndInit();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.pictureBox3).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
