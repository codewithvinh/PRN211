using Microsoft.EntityFrameworkCore;
using Q1.Models;
using System.Linq;

namespace Q1
{
	public partial class Form1 : Form
	{
		PE_PRN211_Fall23B5Context context = new PE_PRN211_Fall23B5Context();
		static List<Project> projects;

		public Form1()
		{
			InitializeComponent();
			Load();
		}

		private void Load()
		{
			LoadProject();
		}

		private void LoadProject()
		{
			projects = context.Projects.ToList();
			cbxType.DataSource = projects.Select(x => x.Type).Distinct().ToList();
			cbxType.DisplayMember = "Type";
			dgvProject.DataSource = projects.ToList().
				Select(x => new
				{
					x.Id,
					x.Name,
					x.Description,
					x.StartDate,
					x.Type
				}).ToList();
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			Project project = projects.FirstOrDefault(x => x.Id == int.Parse(txtID.Text));
			project.Name = txtName.Text;
			project.Description = rtxtDescription.Text;
			string dateString = dtpStartDate.Value.ToString("dd/MM/yyyy");
			project.StartDate = DateTime.Parse(dateString);
			project.Type = cbxType.SelectedItem.ToString();
			LoadProject();
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			txtID.Clear();
			txtName.Clear();
			rtxtDescription.Clear();
			dtpStartDate.Value = DateTime.Now; 
			cbxType.SelectedIndex = -1; 

			dgvProject.DataSource = null;

			LoadProject();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			Project project = new Project();
			project.Name = txtName.Text;
			project.Description = rtxtDescription.Text;
			string dateString = dtpStartDate.Value.ToString("dd/MM/yyyy");
			project.StartDate = DateTime.Parse(dateString);
			project.Type = cbxType.SelectedItem.ToString();
			context.Projects.Add(project);
			context.SaveChanges();
			LoadProject();
		}

		private void dgvProject_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			string id = dgvProject.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
			int ID = int.Parse(id);
			Project project = projects.FirstOrDefault(x => x.Id == ID);
			txtID.Text = project.Id.ToString();
			txtName.Text = project.Name;
			rtxtDescription.Text = project.Description;
			dtpStartDate.Value = DateTime.Parse(project.StartDate.ToString());
			cbxType.SelectedItem = project.Type;

		}
	}
}