using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TO_DO_LIST {
	public partial class LinkForm:Form {
		public LinkForm( ) {
			InitializeComponent( );
			}

		private void Load_Link( ) {
			SqlConnection connection = new SqlConnection( "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=todo;Integrated Security=True" );
			connection.Open( );

			String query = "Select Title, Link from Link where Id = @id";
			SqlCommand command = new SqlCommand( query , connection );
			command.Parameters.AddWithValue( "@id" , Global.link_id );
			SqlDataReader reader = command.ExecuteReader( );
			reader.Read( );

			LinkTitle.Text = reader.GetValue( 0 ).ToString( );
			Link.Text = reader.GetValue( 1 ).ToString( );

			connection.Close( );
			}

		private void CancelButton_Click( object sender,EventArgs e ) {
			SqlConnection connection = new SqlConnection( "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=todo;Integrated Security=True" );
			connection.Open( );

			try {
				String query = "Delete Link where Title = @title";
				using( SqlCommand command = new SqlCommand( query , connection ) ) {
					command.Parameters.AddWithValue( "@title" , LinkTitle.Text );
					command.ExecuteNonQuery( );
					command.Dispose( );
					}
				}
			catch {
				MessageBox.Show( "Link not found." );
				}
			connection.Close( );
			LinkForm.ActiveForm.Close( );
			}

		private void ConfirmButton_Click( object sender,EventArgs e ) {
			if( Global.link_new == true ) {
				InsertLink( );
				}
			else {
				UpdateLink( );
				}
			LinkForm.ActiveForm.Close( );
			}

		private void InsertLink( ) {
			SqlConnection connectionRead = new SqlConnection( "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=todo;Integrated Security=True" );
			connectionRead.Open( );
			int id;
			try {
				String read = "SELECT Id FROM Link WHERE id = ( SELECT max( id ) FROM Link)";
				SqlCommand commandRead = new SqlCommand( read , connectionRead );
				SqlDataReader reader = commandRead.ExecuteReader( );
				reader.Read( );
				id = Convert.ToInt32( reader.GetValue( 0 ) ) + 1;
				}
			catch {
				id = 0;
				}

			SqlConnection connection = new SqlConnection( "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=todo;Integrated Security=True" );
			connection.Open( );
			String query = "Insert into Link (Title,Link,TaskId,Id) values(@title, @link, @taskid, @id)";
			using( SqlCommand command = new SqlCommand( query , connection ) ) {
				command.Parameters.AddWithValue( "@title" , LinkTitle.Text );
				command.Parameters.AddWithValue( "@link" , Link.Text );
				command.Parameters.AddWithValue( "@taskid" , Global.ID );
				command.Parameters.AddWithValue( "@id" , id );
				command.ExecuteNonQuery( );
				command.Dispose( );
				}
			connection.Close( );
			}

		private void UpdateLink( ) {
			SqlConnection connection = new SqlConnection( "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=todo;Integrated Security=True" );
			connection.Open( );

			String query = "Update Link set Title = @title, Link = @link where Id = @id";
			using( SqlCommand command = new SqlCommand( query , connection ) ) {
				command.Parameters.AddWithValue( "@title" , LinkTitle.Text );
				command.Parameters.AddWithValue( "@link" , Link.Text );
				command.Parameters.AddWithValue( "@id" , Global.link_id );
				command.ExecuteNonQuery( );
				command.Dispose( );
				}

			connection.Close( );
			}

		private void LinkForm_Load( object sender , EventArgs e ) {
			if( Global.link_new == true ) {
				LinkTitle.Text = "New";
				Link.Text = "";
				}
			else {
				Load_Link( );
				}
			}

		private void copyToolStripMenuItem_Click( object sender , EventArgs e ) {
			Clipboard.SetText( Link.SelectedText );
			}
		}
	}


