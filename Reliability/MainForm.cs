/*
 * Created by SharpDevelop.
 * User: Acer
 * Date: 30.09.2017
 * Time: 17:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace LR1
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		Dictionary<string, double> operations = new Dictionary<string, double>();
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			operations.Add("Простая, рутинная", 0.001);
			operations.Add("Требующая внимания, рутинная", 0.01);
			operations.Add("Нестандартная", 0.1);
			
			operations.Add("2", 10);
			operations.Add("10", 1);
			operations.Add("20", 0.5);
			operations.Add("3", 10);
			operations.Add("30", 1);
			operations.Add("45", 0.3);
			operations.Add("60", 0.1);
			
			operations.Add("Тщательно отобран, хорошо тренирован", 3);
			operations.Add("Средних знаний и тренировки", 2);
			operations.Add("Мало знаний, слабо тренирован", 1);
			
			operations.Add("Аварийная ситуация", 3);
			operations.Add("Потенциально аварийная ситуация", 2);
			operations.Add("Нормальная ситуация", 1);
			
			operations.Add("Отличный микроклимат, отличное взаимодействие с объектом", 0.7);
			operations.Add("Хороший микроклимат, хорошее взаимодействие", 1);
			operations.Add("Натянутая обстановка и взаимодействие", 3);
			operations.Add("Натянутая обстановка, плохое взаимодействие", 7);
			operations.Add("Плохой микроклимат, плохое взаимодействие", 10);
			
			comboBox1.Items.Add("Простая, рутинная");
			comboBox1.Items.Add("Требующая внимания, рутинная");
			comboBox1.Items.Add("Нестандартная");
			
			comboBox2.Items.Add("2");
			comboBox2.Items.Add("10");
			comboBox2.Items.Add("20");
			comboBox2.Items.Add("3");
			comboBox2.Items.Add("30");
			comboBox2.Items.Add("45");
			comboBox2.Items.Add("60");
			
			comboBox3.Items.Add("Тщательно отобран, хорошо тренирован");
			comboBox3.Items.Add("Средних знаний и тренировки");
			comboBox3.Items.Add("Мало знаний, слабо тренирован");

			comboBox4.Items.Add("Аварийная ситуация");
			comboBox4.Items.Add("Потенциально аварийная ситуация");
			comboBox4.Items.Add("Нормальная ситуация");
			
			comboBox5.Items.Add("Отличный микроклимат, отличное взаимодействие с объектом");
			comboBox5.Items.Add("Хороший микроклимат, хорошее взаимодействие");
			comboBox5.Items.Add("Натянутая обстановка и взаимодействие");
			comboBox5.Items.Add("Натянутая обстановка, плохое взаимодействие");
			comboBox5.Items.Add("Плохой микроклимат, плохое взаимодействие");
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
			double K=1;
			if(comboBox1.Text!=""||comboBox2.Text!=""||comboBox3.Text!=""||comboBox4.Text!=""||comboBox5.Text!=""){
				K=K*operations[comboBox1.Text]*operations[comboBox2.Text]*operations[comboBox3.Text];
				K=K*operations[comboBox4.Text]*operations[comboBox5.Text];
			}
			double P = 1 - K;
			textBox1.Text = P.ToString();
		}
	}
}
