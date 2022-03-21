using Examination_system.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination_system.Forms.Dialogs
{
	public partial class DepartmentPrompetDialog : Form
	{
		public ExamSystemEntities Ent { get; set; } = new ExamSystemEntities();
		public int DeptId { get; set; }
		public string DeptName { get; set; }

		public DepartmentPrompetDialog()
		{
			InitializeComponent();
			FillDeptsComboBox();
		}

		private void FillDeptsComboBox()
		{
			var depts = Ent.Departments
				.Select(d => d.Dept_Name)
				.ToList();
			foreach (var dept in depts)
			{
				DeptsCombo.Items.Add(dept);
			}
		}

		private void Select_Click(object sender, EventArgs e)
		{
			if (DeptsCombo.Text != String.Empty
				&& DeptsCombo.Items.Contains(DeptsCombo.Text))
			{
				var deptId = Ent.Departments
					.Where(d => d.Dept_Name == DeptsCombo.Text)
					.Select(d => d.Dept_Id)
					.FirstOrDefault();
				DeptName = DeptsCombo.Text;
				DeptId = deptId;
				DialogResult = DialogResult.OK;
				this.Close();
			}
			else
			{
				MessageBox.Show("Please, Select Department");
			}
		}
	}
}
