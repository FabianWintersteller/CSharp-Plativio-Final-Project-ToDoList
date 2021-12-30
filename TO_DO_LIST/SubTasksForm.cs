using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TO_DO_LIST {
	public partial class SubTasksForm:Form {
		public SubTasksForm( ) {
			InitializeComponent( );
			SubTitleBox.Text = Global.sub_task_title;
			}

		private void SubConfirmButton_Click( object sender , EventArgs e ) {
			if( Global.sub_task_new == true ) {
				InsertSubTask( );
				SubTasksForm.ActiveForm.Close( );
				}
			else {
				UpdateSubTask( );
				SubTasksForm.ActiveForm.Close( );
				}
			}

		private void InsertSubTask( ) {
			SqlConnection connectionRead = new SqlConnection( "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=todo;Integrated Security=True" );
			connectionRead.Open( );

			String read = "SELECT Id FROM SubTasks WHERE id = ( SELECT max( id ) FROM SubTasks)";
			SqlCommand commandRead = new SqlCommand( read , connectionRead );
			SqlDataReader reader = commandRead.ExecuteReader( );
			reader.Read( );
			int id;
			try {
				id = Convert.ToInt32( reader.GetValue( 0 ) ) + 1;
				}
			catch {
				id = 0;
				}
			reader.Close( );
			commandRead.Dispose( );
			connectionRead.Close( );

			SqlConnection connection = new SqlConnection( "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=todo;Integrated Security=True" );
			connection.Open( );

			String query = "Insert into SubTasks (Title,Status,SubId, Id) values(@title, @status, @subid, @id)";
			using( SqlCommand command = new SqlCommand( query , connection ) ) {
				command.Parameters.AddWithValue( "@title" , SubTitleBox.Text );
				command.Parameters.AddWithValue( "@status" , 0 );
				command.Parameters.AddWithValue( "@subid" , Global.ID );
				command.Parameters.AddWithValue( "@id" , id );
				command.ExecuteNonQuery( );
				command.Dispose( );
				}
			connection.Close( );
			}

		private void UpdateSubTask( ) {
			SqlConnection connection = new SqlConnection( "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=todo;Integrated Security=True" );
			connection.Open( );

			String query = "UPDATE SubTasks set Title = @title where SubId = @id";
			using( SqlCommand command = new SqlCommand( query , connection ) ) {
				command.Parameters.AddWithValue( "@title", SubTitleBox.Text );
				command.Parameters.AddWithValue( "@id" , Global.sub_task_id );
				command.ExecuteNonQuery( );
				command.Dispose( );
				}
			connection.Close( );
			}

		private void DeleteSubTask( ) {
			SqlConnection connection = new SqlConnection( "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=todo;Integrated Security=True" );
			connection.Open( );
			try {	
			String query = "DELETE SubTasks where Title = @title";
			using( SqlCommand command = new SqlCommand( query , connection ) ) {
				command.Parameters.AddWithValue( "@title" , SubTitleBox.Text );
				command.ExecuteNonQuery( );
				command.Dispose( );
				}
			}
			catch {
				MessageBox.Show( "Subtask could not be found." );
				}
			connection.Close( );
			}

		private void SubTaskDeleteButton_Click( object sender , EventArgs e ) {
			DeleteSubTask( );
			SubTasksForm.ActiveForm.Close( );
			}
		}
	}