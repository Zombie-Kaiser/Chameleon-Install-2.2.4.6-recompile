using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Chameleon_Install;

public class chameleon : Form
{
	private List<string> names = new List<string>();

	private List<string> paths = new List<string>();

	private IContainer components;

	private Button button1;

	private CheckBox checkBox1;

	private TextBox textBox1;

	private TextBox textBox2;

	private CheckBox checkBox2;

	private TextBox textBox3;

	private CheckBox checkBox3;

	private CheckBox checkBox4;

	private CheckBox checkBox5;

	private CheckBox checkBox6;

	private CheckBox checkBox7;

	private CheckBox checkBox8;

	private CheckBox checkBox9;

	private CheckBox checkBox10;

	private CheckBox checkBox11;

	private CheckBox checkBox12;

	private CheckBox checkBox13;

	private CheckBox checkBox14;

	private CheckBox checkBox15;

	private CheckBox checkBox16;

	private CheckBox checkBox17;

	private CheckBox checkBox18;

	private CheckBox checkBox19;

	private TextBox textBox4;

	private TextBox textBox5;

	private CheckBox checkBox20;

	private CheckBox checkBox21;

	private CheckBox checkBox22;

	private CheckBox checkBox23;

	private CheckBox checkBox24;

	private CheckBox checkBox25;

	private CheckBox checkBox26;

	private CheckBox checkBox27;

	private TextBox textBox6;

	private CheckBox checkBox28;

	private CheckBox checkBox29;

	private CheckBox checkBox30;

	private CheckBox checkBox31;

	private CheckBox checkBox32;

	private CheckBox checkBox33;

	private CheckBox checkBox42;

	private CheckBox checkBox43;

	private CheckBox checkBox44;

	private CheckBox checkBox45;

	private TextBox textBox7;

	private ComboBox comboBox1;

	private TextBox textBox8;

	private GroupBox groupBox1;

	private Label label1;

	private LinkLabel linkLabel1;

	private TextBox textBox9;

	private CheckBox checkBox34;

	private CheckBox checkBox35;

	private CheckBox checkBox36;

	public chameleon()
	{
		InitializeComponent();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		xmlwriter();
		checkboxisChecked();
		InsertXml(names, paths);
	}

	public void xmlwriter()
	{
		XmlTextWriter xmlTextWriter = new XmlTextWriter("org.chameleon.Boot.plist", Encoding.UTF8);
		xmlTextWriter.Formatting = Formatting.Indented;
		xmlTextWriter.Indentation = 4;
		xmlTextWriter.WriteStartDocument();
		xmlTextWriter.WriteDocType("plist", "-//Apple//DTD PLIST 1.0//EN", "http://www.apple.com/DTDs/PropertyList-1.0.dtd", null);
		xmlTextWriter.WriteStartElement("plist");
		xmlTextWriter.WriteAttributeString("version", "1.0");
		xmlTextWriter.WriteEndElement();
		xmlTextWriter.Flush();
		xmlTextWriter.Close();
	}

	public void InsertXml(List<string> name, List<string> path)
	{
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.Load("org.chameleon.Boot.plist");
		XmlNodeList childNodes = xmlDocument.SelectSingleNode("plist").ChildNodes;
		_ = childNodes.Count;
		XmlNode xmlNode = xmlDocument.SelectSingleNode("plist");
		XmlElement xmlElement = xmlDocument.CreateElement("dict");
		for (int i = 0; i < name.Count; i++)
		{
			XmlElement xmlElement2 = xmlDocument.CreateElement("key");
			xmlElement2.InnerText = name[i];
			xmlElement.AppendChild(xmlElement2);
			XmlElement xmlElement3 = xmlDocument.CreateElement("string");
			xmlElement3.InnerText = path[i];
			xmlElement.AppendChild(xmlElement3);
			xmlNode.AppendChild(xmlElement);
		}
		xmlDocument.Save("org.chameleon.Boot.plist");
		name.Clear();
		path.Clear();
	}

	private void checkBox1_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox1.Checked)
		{
			textBox1.Enabled = true;
		}
		else
		{
			textBox1.Enabled = false;
		}
	}

	private void checkBox2_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox2.Checked)
		{
			textBox2.Enabled = true;
		}
		else
		{
			textBox2.Enabled = false;
		}
	}

	private void checkBox3_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox3.Checked)
		{
			textBox3.Enabled = true;
		}
		else
		{
			textBox3.Enabled = false;
		}
	}

	private void checkBox21_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox21.Checked)
		{
			textBox7.Enabled = true;
		}
		else
		{
			textBox7.Enabled = false;
		}
	}

	private void checkBox5_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox5.Checked)
		{
			textBox8.Enabled = true;
		}
		else
		{
			textBox8.Enabled = false;
		}
	}

	private void checkBox10_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox10.Checked)
		{
			textBox4.Enabled = true;
		}
		else
		{
			textBox4.Enabled = false;
		}
	}

	private void checkBox12_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox12.Checked)
		{
			textBox5.Enabled = true;
		}
		else
		{
			textBox5.Enabled = false;
		}
	}

	private void checkBox26_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox26.Checked)
		{
			textBox6.Enabled = true;
		}
		else
		{
			textBox6.Enabled = false;
		}
	}

	private void checkBox34_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox34.Checked)
		{
			textBox9.Enabled = true;
		}
		else
		{
			textBox9.Enabled = false;
		}
	}

	public void checkboxisChecked()
	{
		if (checkBox1.Checked)
		{
			names.Add(checkBox1.Text);
			paths.Add(textBox1.Text);
		}
		if (checkBox2.Checked)
		{
			names.Add(checkBox2.Text);
			paths.Add(textBox2.Text);
		}
		if (checkBox3.Checked)
		{
			names.Add(checkBox3.Text);
			paths.Add(textBox3.Text);
		}
		if (checkBox21.Checked)
		{
			names.Add(checkBox21.Text);
			paths.Add(textBox7.Text);
		}
		if (checkBox5.Checked)
		{
			names.Add(checkBox5.Text);
			paths.Add(textBox8.Text);
		}
		if (checkBox10.Checked)
		{
			names.Add(checkBox10.Text);
			paths.Add(textBox4.Text);
		}
		if (checkBox12.Checked)
		{
			names.Add(checkBox12.Text);
			paths.Add(textBox5.Text);
		}
		if (checkBox26.Checked)
		{
			names.Add(checkBox26.Text);
			paths.Add(textBox6.Text);
		}
		if (checkBox31.Checked)
		{
			names.Add(checkBox31.Text);
			paths.Add(comboBox1.Text);
		}
		if (checkBox34.Checked)
		{
			names.Add(checkBox34.Text);
			paths.Add(textBox9.Text);
		}
		if (checkBox4.Checked)
		{
			names.Add(checkBox4.Text);
			paths.Add("Yes");
		}
		if (checkBox6.Checked)
		{
			names.Add(checkBox6.Text);
			paths.Add("Yes");
		}
		if (checkBox7.Checked)
		{
			names.Add(checkBox7.Text);
			paths.Add("Yes");
		}
		if (checkBox8.Checked)
		{
			names.Add(checkBox8.Text);
			paths.Add("Yes");
		}
		if (checkBox9.Checked)
		{
			names.Add(checkBox9.Text);
			paths.Add("Yes");
		}
		if (checkBox25.Checked)
		{
			names.Add(checkBox25.Text);
			paths.Add("No");
		}
		if (checkBox24.Checked)
		{
			names.Add(checkBox24.Text);
			paths.Add("Yes");
		}
		if (checkBox23.Checked)
		{
			names.Add(checkBox23.Text);
			paths.Add("Yes");
		}
		if (checkBox22.Checked)
		{
			names.Add(checkBox22.Text);
			paths.Add("Yes");
		}
		if (checkBox20.Checked)
		{
			names.Add(checkBox20.Text);
			paths.Add("Yes");
		}
		if (checkBox33.Checked)
		{
			names.Add(checkBox33.Text);
			paths.Add("No");
		}
		if (checkBox32.Checked)
		{
			names.Add(checkBox32.Text);
			paths.Add("Yes");
		}
		if (checkBox11.Checked)
		{
			names.Add(checkBox11.Text);
			paths.Add("Yes");
		}
		if (checkBox19.Checked)
		{
			names.Add(checkBox19.Text);
			paths.Add("Yes");
		}
		if (checkBox18.Checked)
		{
			names.Add(checkBox18.Text);
			paths.Add("No");
		}
		if (checkBox17.Checked)
		{
			names.Add(checkBox17.Text);
			paths.Add("No");
		}
		if (checkBox16.Checked)
		{
			names.Add(checkBox16.Text);
			paths.Add("Yes");
		}
		if (checkBox15.Checked)
		{
			names.Add(checkBox15.Text);
			paths.Add("Yes");
		}
		if (checkBox14.Checked)
		{
			names.Add(checkBox14.Text);
			paths.Add("Yes");
		}
		if (checkBox13.Checked)
		{
			names.Add(checkBox13.Text);
			paths.Add("No");
		}
		if (checkBox27.Checked)
		{
			names.Add(checkBox27.Text);
			paths.Add("Yes");
		}
		if (checkBox45.Checked)
		{
			names.Add(checkBox45.Text);
			paths.Add("Yes");
		}
		if (checkBox44.Checked)
		{
			names.Add(checkBox44.Text);
			paths.Add("Yes");
		}
		if (checkBox43.Checked)
		{
			names.Add(checkBox43.Text);
			paths.Add("Yes");
		}
		if (checkBox42.Checked)
		{
			names.Add(checkBox42.Text);
			paths.Add("Yes");
		}
		if (checkBox30.Checked)
		{
			names.Add(checkBox30.Text);
			paths.Add("Yes");
		}
		if (checkBox29.Checked)
		{
			names.Add(checkBox29.Text);
			paths.Add("Yes");
		}
		if (checkBox28.Checked)
		{
			names.Add(checkBox28.Text);
			paths.Add("Yes");
		}
		if (checkBox35.Checked)
		{
			names.Add(checkBox35.Text);
			paths.Add("Yes");
		}
		if (checkBox36.Checked)
		{
			names.Add(checkBox36.Text);
			paths.Add("Yes");
		}
	}

	private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("http://www.wowpc.cn/thread-33636-1-1.html");
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chameleon_Install.chameleon));
		this.button1 = new System.Windows.Forms.Button();
		this.checkBox1 = new System.Windows.Forms.CheckBox();
		this.textBox1 = new System.Windows.Forms.TextBox();
		this.textBox2 = new System.Windows.Forms.TextBox();
		this.checkBox2 = new System.Windows.Forms.CheckBox();
		this.textBox3 = new System.Windows.Forms.TextBox();
		this.checkBox3 = new System.Windows.Forms.CheckBox();
		this.checkBox4 = new System.Windows.Forms.CheckBox();
		this.checkBox5 = new System.Windows.Forms.CheckBox();
		this.checkBox6 = new System.Windows.Forms.CheckBox();
		this.checkBox7 = new System.Windows.Forms.CheckBox();
		this.checkBox8 = new System.Windows.Forms.CheckBox();
		this.checkBox9 = new System.Windows.Forms.CheckBox();
		this.checkBox10 = new System.Windows.Forms.CheckBox();
		this.checkBox11 = new System.Windows.Forms.CheckBox();
		this.checkBox12 = new System.Windows.Forms.CheckBox();
		this.checkBox13 = new System.Windows.Forms.CheckBox();
		this.checkBox14 = new System.Windows.Forms.CheckBox();
		this.checkBox15 = new System.Windows.Forms.CheckBox();
		this.checkBox16 = new System.Windows.Forms.CheckBox();
		this.checkBox17 = new System.Windows.Forms.CheckBox();
		this.checkBox18 = new System.Windows.Forms.CheckBox();
		this.checkBox19 = new System.Windows.Forms.CheckBox();
		this.textBox4 = new System.Windows.Forms.TextBox();
		this.textBox5 = new System.Windows.Forms.TextBox();
		this.checkBox20 = new System.Windows.Forms.CheckBox();
		this.checkBox21 = new System.Windows.Forms.CheckBox();
		this.checkBox22 = new System.Windows.Forms.CheckBox();
		this.checkBox23 = new System.Windows.Forms.CheckBox();
		this.checkBox24 = new System.Windows.Forms.CheckBox();
		this.checkBox25 = new System.Windows.Forms.CheckBox();
		this.checkBox26 = new System.Windows.Forms.CheckBox();
		this.checkBox27 = new System.Windows.Forms.CheckBox();
		this.textBox6 = new System.Windows.Forms.TextBox();
		this.checkBox28 = new System.Windows.Forms.CheckBox();
		this.checkBox29 = new System.Windows.Forms.CheckBox();
		this.checkBox30 = new System.Windows.Forms.CheckBox();
		this.checkBox31 = new System.Windows.Forms.CheckBox();
		this.checkBox32 = new System.Windows.Forms.CheckBox();
		this.checkBox33 = new System.Windows.Forms.CheckBox();
		this.checkBox42 = new System.Windows.Forms.CheckBox();
		this.checkBox43 = new System.Windows.Forms.CheckBox();
		this.checkBox44 = new System.Windows.Forms.CheckBox();
		this.checkBox45 = new System.Windows.Forms.CheckBox();
		this.textBox7 = new System.Windows.Forms.TextBox();
		this.comboBox1 = new System.Windows.Forms.ComboBox();
		this.textBox8 = new System.Windows.Forms.TextBox();
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.linkLabel1 = new System.Windows.Forms.LinkLabel();
		this.label1 = new System.Windows.Forms.Label();
		this.textBox9 = new System.Windows.Forms.TextBox();
		this.checkBox34 = new System.Windows.Forms.CheckBox();
		this.checkBox35 = new System.Windows.Forms.CheckBox();
		this.checkBox36 = new System.Windows.Forms.CheckBox();
		this.groupBox1.SuspendLayout();
		base.SuspendLayout();
		resources.ApplyResources(this.button1, "button1");
		this.button1.Name = "button1";
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(this.button1_Click);
		resources.ApplyResources(this.checkBox1, "checkBox1");
		this.checkBox1.Name = "checkBox1";
		this.checkBox1.UseVisualStyleBackColor = true;
		this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
		resources.ApplyResources(this.textBox1, "textBox1");
		this.textBox1.Name = "textBox1";
		resources.ApplyResources(this.textBox2, "textBox2");
		this.textBox2.Name = "textBox2";
		resources.ApplyResources(this.checkBox2, "checkBox2");
		this.checkBox2.Name = "checkBox2";
		this.checkBox2.UseVisualStyleBackColor = true;
		this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
		resources.ApplyResources(this.textBox3, "textBox3");
		this.textBox3.Name = "textBox3";
		resources.ApplyResources(this.checkBox3, "checkBox3");
		this.checkBox3.Name = "checkBox3";
		this.checkBox3.UseVisualStyleBackColor = true;
		this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
		resources.ApplyResources(this.checkBox4, "checkBox4");
		this.checkBox4.Name = "checkBox4";
		this.checkBox4.UseVisualStyleBackColor = true;
		resources.ApplyResources(this.checkBox5, "checkBox5");
		this.checkBox5.Name = "checkBox5";
		this.checkBox5.UseVisualStyleBackColor = true;
		this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
		resources.ApplyResources(this.checkBox6, "checkBox6");
		this.checkBox6.Name = "checkBox6";
		this.checkBox6.UseVisualStyleBackColor = true;
		resources.ApplyResources(this.checkBox7, "checkBox7");
		this.checkBox7.Name = "checkBox7";
		this.checkBox7.UseVisualStyleBackColor = true;
		resources.ApplyResources(this.checkBox8, "checkBox8");
		this.checkBox8.Name = "checkBox8";
		this.checkBox8.UseVisualStyleBackColor = true;
		resources.ApplyResources(this.checkBox9, "checkBox9");
		this.checkBox9.Name = "checkBox9";
		this.checkBox9.UseVisualStyleBackColor = true;
		resources.ApplyResources(this.checkBox10, "checkBox10");
		this.checkBox10.Name = "checkBox10";
		this.checkBox10.UseVisualStyleBackColor = true;
		this.checkBox10.CheckedChanged += new System.EventHandler(this.checkBox10_CheckedChanged);
		resources.ApplyResources(this.checkBox11, "checkBox11");
		this.checkBox11.Name = "checkBox11";
		this.checkBox11.UseVisualStyleBackColor = true;
		resources.ApplyResources(this.checkBox12, "checkBox12");
		this.checkBox12.Name = "checkBox12";
		this.checkBox12.UseVisualStyleBackColor = true;
		this.checkBox12.CheckedChanged += new System.EventHandler(this.checkBox12_CheckedChanged);
		resources.ApplyResources(this.checkBox13, "checkBox13");
		this.checkBox13.ForeColor = System.Drawing.Color.Red;
		this.checkBox13.Name = "checkBox13";
		this.checkBox13.UseVisualStyleBackColor = true;
		resources.ApplyResources(this.checkBox14, "checkBox14");
		this.checkBox14.Name = "checkBox14";
		this.checkBox14.UseVisualStyleBackColor = true;
		resources.ApplyResources(this.checkBox15, "checkBox15");
		this.checkBox15.Name = "checkBox15";
		this.checkBox15.UseVisualStyleBackColor = true;
		resources.ApplyResources(this.checkBox16, "checkBox16");
		this.checkBox16.Name = "checkBox16";
		this.checkBox16.UseVisualStyleBackColor = true;
		resources.ApplyResources(this.checkBox17, "checkBox17");
		this.checkBox17.ForeColor = System.Drawing.Color.Red;
		this.checkBox17.Name = "checkBox17";
		this.checkBox17.UseVisualStyleBackColor = true;
		resources.ApplyResources(this.checkBox18, "checkBox18");
		this.checkBox18.ForeColor = System.Drawing.Color.Red;
		this.checkBox18.Name = "checkBox18";
		this.checkBox18.UseVisualStyleBackColor = true;
		resources.ApplyResources(this.checkBox19, "checkBox19");
		this.checkBox19.Name = "checkBox19";
		this.checkBox19.UseVisualStyleBackColor = true;
		resources.ApplyResources(this.textBox4, "textBox4");
		this.textBox4.Name = "textBox4";
		resources.ApplyResources(this.textBox5, "textBox5");
		this.textBox5.Name = "textBox5";
		resources.ApplyResources(this.checkBox20, "checkBox20");
		this.checkBox20.Name = "checkBox20";
		this.checkBox20.UseVisualStyleBackColor = true;
		resources.ApplyResources(this.checkBox21, "checkBox21");
		this.checkBox21.Name = "checkBox21";
		this.checkBox21.UseVisualStyleBackColor = true;
		this.checkBox21.CheckedChanged += new System.EventHandler(this.checkBox21_CheckedChanged);
		resources.ApplyResources(this.checkBox22, "checkBox22");
		this.checkBox22.Name = "checkBox22";
		this.checkBox22.UseVisualStyleBackColor = true;
		resources.ApplyResources(this.checkBox23, "checkBox23");
		this.checkBox23.Name = "checkBox23";
		this.checkBox23.UseVisualStyleBackColor = true;
		resources.ApplyResources(this.checkBox24, "checkBox24");
		this.checkBox24.Name = "checkBox24";
		this.checkBox24.UseVisualStyleBackColor = true;
		resources.ApplyResources(this.checkBox25, "checkBox25");
		this.checkBox25.ForeColor = System.Drawing.Color.Red;
		this.checkBox25.Name = "checkBox25";
		this.checkBox25.UseVisualStyleBackColor = true;
		resources.ApplyResources(this.checkBox26, "checkBox26");
		this.checkBox26.Name = "checkBox26";
		this.checkBox26.UseVisualStyleBackColor = true;
		this.checkBox26.CheckedChanged += new System.EventHandler(this.checkBox26_CheckedChanged);
		resources.ApplyResources(this.checkBox27, "checkBox27");
		this.checkBox27.Name = "checkBox27";
		this.checkBox27.UseVisualStyleBackColor = true;
		resources.ApplyResources(this.textBox6, "textBox6");
		this.textBox6.Name = "textBox6";
		resources.ApplyResources(this.checkBox28, "checkBox28");
		this.checkBox28.Name = "checkBox28";
		this.checkBox28.UseVisualStyleBackColor = true;
		resources.ApplyResources(this.checkBox29, "checkBox29");
		this.checkBox29.Name = "checkBox29";
		this.checkBox29.UseVisualStyleBackColor = true;
		resources.ApplyResources(this.checkBox30, "checkBox30");
		this.checkBox30.Name = "checkBox30";
		this.checkBox30.UseVisualStyleBackColor = true;
		resources.ApplyResources(this.checkBox31, "checkBox31");
		this.checkBox31.Name = "checkBox31";
		this.checkBox31.UseVisualStyleBackColor = true;
		resources.ApplyResources(this.checkBox32, "checkBox32");
		this.checkBox32.Name = "checkBox32";
		this.checkBox32.UseVisualStyleBackColor = true;
		resources.ApplyResources(this.checkBox33, "checkBox33");
		this.checkBox33.ForeColor = System.Drawing.Color.Red;
		this.checkBox33.Name = "checkBox33";
		this.checkBox33.UseVisualStyleBackColor = true;
		resources.ApplyResources(this.checkBox42, "checkBox42");
		this.checkBox42.Name = "checkBox42";
		this.checkBox42.UseVisualStyleBackColor = true;
		resources.ApplyResources(this.checkBox43, "checkBox43");
		this.checkBox43.Name = "checkBox43";
		this.checkBox43.UseVisualStyleBackColor = true;
		resources.ApplyResources(this.checkBox44, "checkBox44");
		this.checkBox44.Name = "checkBox44";
		this.checkBox44.UseVisualStyleBackColor = true;
		resources.ApplyResources(this.checkBox45, "checkBox45");
		this.checkBox45.Name = "checkBox45";
		this.checkBox45.UseVisualStyleBackColor = true;
		resources.ApplyResources(this.textBox7, "textBox7");
		this.textBox7.Name = "textBox7";
		this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBox1.FormattingEnabled = true;
		this.comboBox1.Items.AddRange(new object[2]
		{
			resources.GetString("comboBox1.Items"),
			resources.GetString("comboBox1.Items1")
		});
		resources.ApplyResources(this.comboBox1, "comboBox1");
		this.comboBox1.Name = "comboBox1";
		resources.ApplyResources(this.textBox8, "textBox8");
		this.textBox8.Name = "textBox8";
		this.groupBox1.Controls.Add(this.linkLabel1);
		this.groupBox1.Controls.Add(this.label1);
		resources.ApplyResources(this.groupBox1, "groupBox1");
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.TabStop = false;
		resources.ApplyResources(this.linkLabel1, "linkLabel1");
		this.linkLabel1.Name = "linkLabel1";
		this.linkLabel1.TabStop = true;
		this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
		resources.ApplyResources(this.label1, "label1");
		this.label1.ForeColor = System.Drawing.Color.Red;
		this.label1.Name = "label1";
		resources.ApplyResources(this.textBox9, "textBox9");
		this.textBox9.Name = "textBox9";
		resources.ApplyResources(this.checkBox34, "checkBox34");
		this.checkBox34.Name = "checkBox34";
		this.checkBox34.UseVisualStyleBackColor = true;
		this.checkBox34.CheckedChanged += new System.EventHandler(this.checkBox34_CheckedChanged);
		resources.ApplyResources(this.checkBox35, "checkBox35");
		this.checkBox35.Name = "checkBox35";
		this.checkBox35.UseVisualStyleBackColor = true;
		resources.ApplyResources(this.checkBox36, "checkBox36");
		this.checkBox36.Name = "checkBox36";
		this.checkBox36.UseVisualStyleBackColor = true;
		resources.ApplyResources(this, "$this");
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.Controls.Add(this.checkBox36);
		base.Controls.Add(this.checkBox35);
		base.Controls.Add(this.textBox9);
		base.Controls.Add(this.checkBox34);
		base.Controls.Add(this.groupBox1);
		base.Controls.Add(this.textBox8);
		base.Controls.Add(this.comboBox1);
		base.Controls.Add(this.textBox7);
		base.Controls.Add(this.checkBox42);
		base.Controls.Add(this.checkBox43);
		base.Controls.Add(this.checkBox44);
		base.Controls.Add(this.checkBox45);
		base.Controls.Add(this.checkBox28);
		base.Controls.Add(this.checkBox29);
		base.Controls.Add(this.checkBox30);
		base.Controls.Add(this.checkBox31);
		base.Controls.Add(this.checkBox32);
		base.Controls.Add(this.checkBox33);
		base.Controls.Add(this.textBox6);
		base.Controls.Add(this.checkBox20);
		base.Controls.Add(this.checkBox21);
		base.Controls.Add(this.checkBox22);
		base.Controls.Add(this.checkBox23);
		base.Controls.Add(this.checkBox24);
		base.Controls.Add(this.checkBox25);
		base.Controls.Add(this.checkBox26);
		base.Controls.Add(this.checkBox27);
		base.Controls.Add(this.textBox5);
		base.Controls.Add(this.textBox4);
		base.Controls.Add(this.checkBox12);
		base.Controls.Add(this.checkBox13);
		base.Controls.Add(this.checkBox14);
		base.Controls.Add(this.checkBox15);
		base.Controls.Add(this.checkBox16);
		base.Controls.Add(this.checkBox17);
		base.Controls.Add(this.checkBox18);
		base.Controls.Add(this.checkBox19);
		base.Controls.Add(this.checkBox11);
		base.Controls.Add(this.checkBox10);
		base.Controls.Add(this.checkBox9);
		base.Controls.Add(this.checkBox8);
		base.Controls.Add(this.checkBox7);
		base.Controls.Add(this.checkBox6);
		base.Controls.Add(this.checkBox5);
		base.Controls.Add(this.checkBox4);
		base.Controls.Add(this.textBox3);
		base.Controls.Add(this.checkBox3);
		base.Controls.Add(this.textBox2);
		base.Controls.Add(this.checkBox2);
		base.Controls.Add(this.textBox1);
		base.Controls.Add(this.checkBox1);
		base.Controls.Add(this.button1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "chameleon";
		base.ShowIcon = false;
		base.ShowInTaskbar = false;
		base.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
		this.groupBox1.ResumeLayout(false);
		this.groupBox1.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
