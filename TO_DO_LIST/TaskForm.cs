using System;
using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TO_DO_LIST {
	public partial class MainForm:Form {

		public MainForm() {
			InitializeComponent( );

			//Load Values
			SqlConnection connection = new SqlConnection( "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=todo;Integrated Security=True" );
			connection.Open( );
			String sql = "Select Title,Date,Progress,Priority,Category,Amount,Completion from ToDo where Id = @global";
			SqlCommand command = new SqlCommand( sql , connection );
			command.Parameters.AddWithValue( "@global" , Global.ID );
			SqlDataReader reader = command.ExecuteReader( );
			reader.Read( );
			TitleBox.Text = reader.GetString( 0 );
			DueTimePicker.Value = reader.GetDateTime( 1 );
			progressBar1.Minimum = 0;
			progressBar1.Maximum = 10;
			progressBar1.Value = Convert.ToInt32( reader.GetValue( 2 ) );
			PriorityDropdown.SelectedIndex = Convert.ToInt32( reader.GetValue( 3 ) );
			CategoryDropdown.SelectedIndex = Convert.ToInt32( reader.GetValue( 4 ) );
			AmountBox.Text = reader.GetValue( 5 ).ToString( );
			int completion = Convert.ToInt32( reader.GetValue( 6 ) );
			if( completion == 1 ) {
				CompletedCheck.Checked = true;
				}
			else if( completion == 2 ) {
				MissedCheck.Checked = true;
				}
			else if( completion == 3 ) {
				PostponedCheck.Checked = true;
				}
			reader.Close( );
			command.Dispose( );
			connection.Close( );

			LoadSubTasks( );
		
			//Amount Box Hide
				if( CategoryDropdown.SelectedItem.ToString( ) == "Finance" ) {
				AmountBox.Show( );
				label7.Show( );
				}
			else {
				AmountBox.Hide( );
				label7.Hide( );
				}
			}

		private void comboBox2_SelectedIndexChanged( object sender,EventArgs e ) {
			if(CategoryDropdown.SelectedItem.ToString() == "Finance") {
				AmountBox.Show( );
				label7.Show( );
				}
			else {
				AmountBox.Hide( );
				label7.Hide( ) ;
				}
			}

		private void checkBox1_CheckedChanged( object sender,EventArgs e ) {
			if( CompletedCheck.Checked == true ) {
				MissedCheck.Checked = false;
				PostponedCheck.Checked = false;
				progressBar1.Value = 10;
				PlusButton.Hide( );
				MinusButton.Hide( );
				}
			else {
				PlusButton.Show( );
				MinusButton.Show( );
				progressBar1.Value = 0;
				}
			}

		private void MissedCheck_CheckedChanged( object sender,EventArgs e ) {
			if( MissedCheck.Checked == true ) {
				CompletedCheck.Checked = false;
				PostponedCheck.Checked = false;
				progressBar1.Value = 10;
				progressBar1.SetState( 2 );
				PlusButton.Hide( );
				MinusButton.Hide( );
				}
			else {
				PlusButton.Show( );
				MinusButton.Show( );
				progressBar1.Value = 0;
				progressBar1.SetState( 1 );
				}
			}

		private void PostponedCheck_CheckedChanged( object sender,EventArgs e ) {
			if( PostponedCheck.Checked == true ) {
				CompletedCheck.Checked = false;
				MissedCheck.Checked = false;
				progressBar1.Value = 10;
				progressBar1.SetState(3);
				PlusButton.Hide( );
				MinusButton.Hide( );
				}
			else {
				PlusButton.Show( );
				MinusButton.Show( );
				progressBar1.Value = 0;
				progressBar1.SetState(1);
				}
			}

		private void SaveButton_Click( object sender,EventArgs e ) {
			Sql_Update( TitleBox.Text , progressBar1.Value , DueTimePicker.Value , PriorityDropdown.SelectedIndex , CategoryDropdown.SelectedIndex , AmountBox.Text , CompletedCheck.Checked, MissedCheck.Checked, PostponedCheck.Checked , Global.ID.ToString( ) );
			MessageBox.Show( "Saved!" );
			}

		private void DeleteButton_Click( object sender,EventArgs e ) {
			DeleteForm df = new DeleteForm( );
			df.Show( );
			}

		private void LinkDropdown_SelectedIndexChanged( object sender,EventArgs e ) {
			if( LinkDropdown.SelectedItem.ToString( ) == "Add.." ) {
				Global.link_new = true;
				LinkForm lf = new LinkForm( );
				lf.Show( );
				}
			else {
				GetLinkId( );
				Global.link_new = false;
				LinkForm lf = new LinkForm( );
				lf.Show( );
				}
			}

		private void GetLinkId( ) {
			SqlConnection connection = new SqlConnection( "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=todo;Integrated Security=True" );
			connection.Open( );

			String query = "Select Id from Link where Title = @title";
			SqlCommand command = new SqlCommand( query , connection );
			command.Parameters.AddWithValue( "@title" , LinkDropdown.SelectedItem.ToString( ) );
			SqlDataReader reader = command.ExecuteReader( );
			reader.Read( );

			Global.link_id = Convert.ToInt32( reader.GetValue( 0 ) );
			connection.Close( );
			}

		private void Sql_Update( string title , int progress , DateTime date , int priority , int category , string amount , bool completed, bool missed, bool postponed , string ID ) {
			int completion;
			if( completed == true ) {
				completion = 1;
				}
			else if( missed == true ) {
				completion = 2;
				}
			else if( postponed == true ) {
				completion = 3;
				}
			else {
				completion = 0;
				}

			int id = Convert.ToInt32( ID );
			
			SqlConnection connection = new SqlConnection( "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=todo;Integrated Security=True" );
			connection.Open( );
			SqlDataAdapter adapter = new SqlDataAdapter( );
			String query = "update ToDo set Title = @title, Date = @date, Progress = @progress, Priority = @priority, Category = @category, Amount = @amount, Completion = @completion where Id = @id ";
			using( SqlCommand command = new SqlCommand( query , connection ) ) {
				command.Parameters.AddWithValue( "@title" , title );
				command.Parameters.AddWithValue( "@date" , date );
				command.Parameters.AddWithValue( "@progress" , progress );
				command.Parameters.AddWithValue( "@priority" , priority );
				command.Parameters.AddWithValue( "@category" , category );
				command.Parameters.AddWithValue( "@amount" , amount );
				command.Parameters.AddWithValue( "@completion" , completion );
				command.Parameters.AddWithValue( "@id" , id );
				command.ExecuteNonQuery( );
				command.Dispose( );
				}
			connection.Close( );
			}

		private void PlusButton_Click( object sender , EventArgs e ) {
			if( progressBar1.Value < 10 ) {
				progressBar1.Value++;
				}
			else {
				}
			}

		private void MinusButton_Click( object sender , EventArgs e ) {
			if( progressBar1.Value > 0 ) {
				progressBar1.Value--;
				}
			}

		private void SubTaskDropdown_SelectedIndexChanged( object sender , EventArgs e ) {
			if( SubTaskDropdown.SelectedItem.ToString( ) == "Add.." ) {
				Global.sub_task_title = "New";
				Global.sub_task_new = true;
				}
			else {
				Global.sub_task_title = SubTaskDropdown.SelectedItem.ToString( );
				Global.sub_task_new = false;
				GetSubId( );
				}
			SubTasksForm stf = new SubTasksForm( );
			stf.Show( );
			}

		private void GetSubId( ) {
			SqlConnection connection = new SqlConnection( "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=todo;Integrated Security=True" );
			connection.Open( );

			String query = "Select SubId from SubTasks where Title = @title";
			SqlCommand command = new SqlCommand( query , connection );
			command.Parameters.AddWithValue( "@title" , SubTaskDropdown.SelectedItem.ToString( ) );
			SqlDataReader reader = command.ExecuteReader( );
			reader.Read( );

			Global.sub_task_id = Convert.ToInt32( reader.GetValue( 0 ) );

			connection.Close( );
			}

		private void LoadSubTasks( ) {
			SqlConnection connectionSub = new SqlConnection( "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=todo;Integrated Security=True" );
			connectionSub.Open( );
			String queryLoadSub = "Select Title,Status,SubId from SubTasks";
			SqlCommand commandLoadSub = new SqlCommand( queryLoadSub , connectionSub );
			SqlDataReader readerSub = commandLoadSub.ExecuteReader( );
			while( readerSub.Read( ) ) {
				if( Global.ID == Convert.ToInt32( readerSub.GetValue( 2 ) ) ) {
					SubTaskDropdown.Items.Add( readerSub.GetValue( 0 ).ToString( ) );
					}
				else {
					continue;
					}
				}
			readerSub.Close( );
			commandLoadSub.Dispose( );
			connectionSub.Close( );
			}

		private void LoadLinks( ) {
			SqlConnection connectionLink = new SqlConnection( "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=todo;Integrated Security=True" );
			connectionLink.Open( );
			String queryLink = "Select Title,Link,TaskId from Link";
			SqlCommand commandLink = new SqlCommand( queryLink , connectionLink );
			SqlDataReader readerLink = commandLink.ExecuteReader( );

			while( readerLink.Read( ) ) {
				if( Global.ID == Convert.ToInt32( readerLink.GetValue( 2 ) ) ) {
					LinkDropdown.Items.Add( readerLink.GetValue( 0 ).ToString( ) );
					}
				}
			}

		private void MainForm_Activated( object sender , EventArgs e ) {
			SubTaskDropdown.Items.Clear( );
			LoadSubTasks( );
			SubTaskDropdown.Items.Add( "Add.." );

			LinkDropdown.Items.Clear( );
			LoadLinks( );
			LinkDropdown.Items.Add( "Add.." );
			}
		}
	}