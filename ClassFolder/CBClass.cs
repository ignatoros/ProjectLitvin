using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ProjectLitvin.ClassFolder
{
    class CBClass
    {
        SqlConnection sqlConnection = new SqlConnection(
            @"Data Source=(local)\SQLEXPRESS;" +
            "Initial Catalog=Litvin;" +
            "Integrated Security=True");
        SqlDataAdapter sqlData;
        DataSet dataSet;

        public enum CBType
        {
            Role,
            Post
        }

        private void RoleCBLoad(ComboBox comboBox)
        {
            try
            {
                sqlConnection.Open();
                sqlData = new SqlDataAdapter("Select RoleId, RoleName " +
                    "From dbo.[Role] Order by RoleId ASC",
                    sqlConnection);
                dataSet = new DataSet();
                sqlData.Fill(dataSet, "[Role]");
                comboBox.ItemsSource = dataSet.Tables["[Role]"].DefaultView;
                comboBox.DisplayMemberPath = dataSet.
                    Tables["[Role]"].Columns["RoleName"].ToString();
                comboBox.SelectedValuePath = dataSet.
                   Tables["[Role]"].Columns["RoleId"].ToString();
            }
            catch (Exception ex)
            {
                MBClass.ErrorMB(ex);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void PostCBLoad(ComboBox comboBox)
        {
            try
            {
                sqlConnection.Open();
                sqlData = new SqlDataAdapter("Select IdPost, PostName " +
                    "From dbo.[Post] Order by IdPost ASC",
                    sqlConnection);
                dataSet = new DataSet();
                sqlData.Fill(dataSet, "[Post]");
                comboBox.ItemsSource = dataSet.Tables["[Post]"].DefaultView;
                comboBox.DisplayMemberPath = dataSet.
                    Tables["[Post]"].Columns["PostName"].ToString();
                comboBox.SelectedValuePath = dataSet.
                   Tables["[Post]"].Columns["RoleId"].ToString();
            }
            catch (Exception ex)
            {
                MBClass.ErrorMB(ex);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public void LoadCB(ComboBox comboBox, CBType type)
        {
            switch (type)
            {
                case CBType.Role:
                    RoleCBLoad(comboBox);
                    break;
                case CBType.Post:
                    PostCBLoad(comboBox);
                    break;
            }
        }
    }
}
