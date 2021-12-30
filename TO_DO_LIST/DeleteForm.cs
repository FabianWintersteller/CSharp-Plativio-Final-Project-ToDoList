using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TO_DO_LIST {
	public partial class DeleteForm:Form {
		public DeleteForm( ) {
			InitializeComponent( );
			}

		private void CancelButton_Click( object sender,EventArgs e ) {
			DeleteForm.ActiveForm.Close( );
			}

		private void ConfirmButton_Click( object sender , EventArgs e ) {
			//Delete Task
			SqlConnection connection = new SqlConnection( "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=todo;Integrated Security=True" );
			connection.Open( );

			String queryDelete = "Delete ToDo where Id = @id";
			using( SqlCommand commandDelete = new SqlCommand( queryDelete , connection ) ) {
				commandDelete.Parameters.AddWithValue( "@id" , Global.ID );
				commandDelete.ExecuteNonQuery( );
				commandDelete.Dispose( );
				}
			connection.Close( );

			//Delete SubTasks
			SqlConnection connection_sub = new SqlConnection( "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=todo;Integrated Security=True" );
			connection_sub.Open( );

			String query_sub = "Delete SubTasks where SubId = @id";
			using( SqlCommand command = new SqlCommand( query_sub , connection_sub ) ) {
				command.Parameters.AddWithValue( "@id" , Global.ID );
				command.ExecuteNonQuery( );
				command.Dispose( );
				}
			connection_sub.Close( );

			//Delete Links
			SqlConnection connection_links = new SqlConnection( "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=todo;Integrated Security=True" );
			connection_links.Open( );

			String query_links = "Delete Link where TaskId = @id";
			using( SqlCommand command = new SqlCommand( query_links , connection_links ) ) {
				command.Parameters.AddWithValue( "@id" , Global.ID );
				command.ExecuteNonQuery( );
				command.Dispose( );
				}
			connection_links.Close( );

			DeleteForm.ActiveForm.Close( );
			MainForm.ActiveForm.Close( );
			}
		}
	}
