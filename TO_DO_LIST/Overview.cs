using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;


namespace TO_DO_LIST {
	public partial class Overview:Form {

		private ListViewColumnSorter sorter;
		public Overview( ) {
			InitializeComponent( );

			sorter = new ListViewColumnSorter( );
			listView1.ListViewItemSorter = sorter;
			}

		private void ConfigureButton_Click( object sender , EventArgs e ) {
			if( listView1.SelectedItems.Count != 0 ) {
				Index( );
				MainForm taskform = new MainForm( );
				taskform.Show( );
				}
			else {
				}
			}

		private void Index( ) {
			Global.ID = Convert.ToInt32( listView1.SelectedItems[0].SubItems[4].Text );	
			}

		private void Overview_Activated( object sender , EventArgs e ) {
			listView1.Items.Clear( );
			listView1.Controls.Clear( );
			LoadList( );
			listView1.Controls.Clear( );
			ProgBarSortLoad( );
			}

		private void NewButton_Click( object sender , EventArgs e ) {
			New( );
			}

		private void New( ) {
			SqlConnection connection = new SqlConnection( "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=todo;Integrated Security=True" );
			connection.Open( );
			String queryRead = "Select Id from ToDo";
			SqlCommand commandRead = new SqlCommand( queryRead , connection );
			SqlDataReader reader = commandRead.ExecuteReader( );
			int last;
			if( listView1.Items.Count > 0 ) {
				for( int i = 0 ; i < listView1.Items.Count ; i++ ) {
					reader.Read( );
					}
				last = Convert.ToInt32( reader.GetValue( 0 ) ) + 1;
				}
			else {
				last = 0;
				}
			reader.Close( );
			DateTime today = DateTime.Now;
			String queryInsert = "Insert into ToDo (Id,Title,Date,Progress,Priority,Category,Amount,Completion) values(@id, @title, @date, @progress, @priority, @category, @amount, @status)";
			using( SqlCommand commandInsert = new SqlCommand( queryInsert , connection ) ) {
				commandInsert.Parameters.AddWithValue( "@id" , last );
				commandInsert.Parameters.AddWithValue( "@title" , "New" );
				commandInsert.Parameters.AddWithValue( "@date" , today );
				commandInsert.Parameters.AddWithValue( "@progress" , 0 );
				commandInsert.Parameters.AddWithValue( "@priority" , 0 );
				commandInsert.Parameters.AddWithValue( "@category" , 0 );
				commandInsert.Parameters.AddWithValue( "@amount" , "0" );
				commandInsert.Parameters.AddWithValue( "@status" , 0 );
				commandInsert.ExecuteNonQuery( );
				commandInsert.Dispose( );
				}
			listView1.Items.Clear( );
			listView1.Controls.Clear( );
			LoadList( );
			connection.Close( );
			}

		private void LoadList( ) {
			SqlConnection connection = new SqlConnection( "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=todo;Integrated Security=True" );
			connection.Open( );

			String sql = "Select Title,Progress,Date,Category,Id,Priority,Amount,Completion from ToDo";
			SqlCommand command = new SqlCommand( sql , connection );
			SqlDataReader reader = command.ExecuteReader( );

			while( reader.Read( ) ) {
				ListViewItem item = new ListViewItem( reader.GetValue( 0 ).ToString( ) );

				string[] category = { " " , "Work" , "Finance" , "Private" };
				string[] status = { " " , "completed" , "missed" , "postponed" };
				string[] priority = { " " , "High" , "Average" , "Low" };
				string[] progress = { "A" , "B" , "C" , "D" , "E" , "F" , "G" , "H" , "I" , "J" , "K" };
				item.SubItems.Add( progress[Convert.ToInt32( reader.GetValue( 1 ) )] );
				item.SubItems.Add( reader.GetValue( 2 ).ToString( ) );
				item.SubItems.Add( category[Convert.ToInt32( reader.GetValue( 3 ) )] );
				item.SubItems.Add( reader.GetValue( 4 ).ToString( ) );
				item.SubItems.Add( status[Convert.ToInt32( reader.GetValue( 7 ) )] );
				item.SubItems.Add( priority[Convert.ToInt32( reader.GetValue( 5 ) )] );

				if( category[Convert.ToInt32( reader.GetValue( 3 ) )] == "Finance" ) {
					item.SubItems.Add( reader.GetValue( 6 ).ToString( ) );
					}
				else {
					item.SubItems.Add( "" );
					}
				
				listView1.Items.Add( item );

		
				int pb_value = Convert.ToInt32( reader.GetValue( 1 ) );
				int pb_status = Convert.ToInt32( reader.GetValue( 7 ) ) ;
				listView1.Controls.Add( LoadProgessbar( item , pb_value , pb_status ) );
				}
			
			reader.Close( );
			command.Dispose( );
			connection.Close( );
			}

		private void DeleteButton_Click( object sender , EventArgs e ) {
			Delete( );
			}

		private void Delete( ) {
			if( listView1.SelectedItems.Count != 0 ) {
				Index( );
				SqlConnection connection = new SqlConnection( "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=todo;Integrated Security=True" );
				connection.Open( );

				String queryDelete = "Delete ToDo where Id = @id";
				using( SqlCommand commandDelete = new SqlCommand( queryDelete , connection ) ) {
					commandDelete.Parameters.AddWithValue( "@id" , Global.ID );
					commandDelete.ExecuteNonQuery( );
					commandDelete.Dispose( );
					}
				connection.Close( );
				listView1.Items.Clear( );
				listView1.Controls.Clear( );
				LoadList( );
				Delete_Subtasks( );
				Delete_Links( );
				}
			else {
				}
			}

		private void Delete_Subtasks( ) {
			SqlConnection connection = new SqlConnection( "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=todo;Integrated Security=True" );
			connection.Open( );

			String query = "Delete SubTasks where SubId = @id";
			using( SqlCommand command = new SqlCommand( query , connection ) ) {
				command.Parameters.AddWithValue( "@id" , Global.ID );
				command.ExecuteNonQuery( );
				command.Dispose( );
				}
			connection.Close( );
			}

		private void Delete_Links( ) {
			SqlConnection connection = new SqlConnection( "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=todo;Integrated Security=True" );
			connection.Open( );

			String query = "Delete Link where TaskId = @id";
			using( SqlCommand command = new SqlCommand( query , connection ) ) {
				command.Parameters.AddWithValue( "@id" , Global.ID );
				command.ExecuteNonQuery( );
				command.Dispose( );
				}
			connection.Close( );
			}

		private ProgressBar LoadProgessbar( ListViewItem item , int value , int status ) {
			ProgressBar pb = new ProgressBar( );
			Rectangle r = item.SubItems[1].Bounds;
			pb.SetBounds( r.X , r.Y , r.Width , r.Height );
			pb.Minimum = 0;
			pb.Maximum = 10;
			pb.Value = value;

			if( status == 0 || status == 1 ) {
				pb.SetState( 1 );
				}
			else if( status == 2 ) {
				pb.SetState( 2 );
				}
			else if( status == 3 ) {
				pb.SetState( 3 );
				}
			return pb;
			}

		private void ShowColumn( int i ) {
			if( listView1.Columns[i].Width != 0 ) {
				listView1.Columns[i].Width = 0;
				}
			else {
				listView1.Columns[i].Width = 60;
				}
			}

		private void taskToolStripMenuItem_Click( object sender , EventArgs e ) {
			ShowColumn( 0 );
			listView1.Items.Clear( );
			listView1.Controls.Clear( );
			LoadList( );
			listView1.Controls.Clear( );
			ProgBarSortLoad( );
			if( taskToolStripMenuItem.Checked == true ) {
				taskToolStripMenuItem.Checked = false;
				}
			else {
				taskToolStripMenuItem.Checked = true;
				}
			}

		private void progressToolStripMenuItem_Click( object sender , EventArgs e ) {
			ShowColumn( 1 );
			listView1.Items.Clear( );
			listView1.Controls.Clear( );
			LoadList( );
			listView1.Controls.Clear( );
			ProgBarSortLoad( );
			if( progressToolStripMenuItem.Checked == true ) {
				progressToolStripMenuItem.Checked = false;
				}
			else {
				progressToolStripMenuItem.Checked = true;
				}
			}

		private void dueDateToolStripMenuItem_Click( object sender , EventArgs e ) {
			ShowColumn( 2 );
			if( dueDateToolStripMenuItem.Checked == true ) {
				dueDateToolStripMenuItem.Checked = false;
				}
			else {
				dueDateToolStripMenuItem.Checked = true;
				}
			}

		private void categoryToolStripMenuItem_Click( object sender , EventArgs e ) {
			ShowColumn( 3 );
			if( categoryToolStripMenuItem.Checked == true ) {
				categoryToolStripMenuItem.Checked = false;
				}
			else {
				categoryToolStripMenuItem.Checked = true;
				}
			}

		private void priorityToolStripMenuItem_Click( object sender , EventArgs e ) {
			ShowColumn( 6 );
			if( priorityToolStripMenuItem.Checked == true ) {
				priorityToolStripMenuItem.Checked = false;
				}
			else {
				priorityToolStripMenuItem.Checked = true;
				}
			}

		private void amountToolStripMenuItem_Click( object sender , EventArgs e ) {
			ShowColumn( 7 );
			if( amountToolStripMenuItem.Checked == true ) {
				amountToolStripMenuItem.Checked = false;
				}
			else {
				amountToolStripMenuItem.Checked = true;
				}
			}

		private void statusToolStripMenuItem_Click( object sender , EventArgs e ) {
			ShowColumn( 5 );
			if( statusToolStripMenuItem.Checked == true ) {
				statusToolStripMenuItem.Checked = false;
				}
			else {
				statusToolStripMenuItem.Checked = true;
				}
			}

		private void listView1_ColumnClick( object sender , ColumnClickEventArgs e ) {
			if( e.Column == sorter.column ) {
				if( sorter.order == System.Windows.Forms.SortOrder.Ascending ) {
					sorter.order = System.Windows.Forms.SortOrder.Descending;
					}
				else {
					sorter.order = System.Windows.Forms.SortOrder.Ascending;
					}
				}
			else {
				sorter.column = e.Column;
				sorter.order = System.Windows.Forms.SortOrder.Ascending;
				}
			listView1.Sort( );
			listView1.Controls.Clear( );
			ProgBarSortLoad( );
			}

		private void ProgBarSortLoad( ) {
			SqlConnection connection = new SqlConnection( "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=todo;Integrated Security=True" );
			connection.Open( );
			String query = "Select Progress,Id,Completion from todo";
			SqlCommand command = new SqlCommand( query , connection );

			foreach( ListViewItem item in listView1.Items ) {
				SqlDataReader reader = command.ExecuteReader( );
				while( reader.Read( ) ) {
					if( reader.GetValue( 1 ).ToString( ) == item.SubItems[4].Text ) {
						listView1.Controls.Add( LoadProgessbar( item , Convert.ToInt32( reader.GetValue( 0 ) ) , Convert.ToInt32( reader.GetValue( 2 ) ) ));
						continue;
						}
					else {
						continue;
						}
					}
				reader.Close( );
				}
			command.Dispose( );
			connection.Close( );
			}

		private void newToolStripMenuItem_Click( object sender , EventArgs e ) {
			New( );
			}

		private void configureToolStripMenuItem_Click( object sender , EventArgs e ) {
			if( listView1.SelectedItems.Count != 0 ) {
				Index( );
				MainForm taskform = new MainForm( );
				taskform.Show( );
				}
			else {
				}
			}

		private void deleteToolStripMenuItem_Click( object sender , EventArgs e ) {
			Delete( );
			}

		private void closeToolStripMenuItem_Click( object sender , EventArgs e ) {
			Application.Exit( );
			}

		private void listView1_ColumnWidthChanging( object sender , ColumnWidthChangingEventArgs e ) {
			listView1.Controls.Clear( );
			ProgBarSortLoad( );
			}
		}

	public class ListViewColumnSorter : IComparer {
		private int column_to_sort;
		private System.Windows.Forms.SortOrder sort_order;
		private CaseInsensitiveComparer object_compare;

		public ListViewColumnSorter( ) {
			column_to_sort = 0;
			sort_order = System.Windows.Forms.SortOrder.None;
			object_compare = new CaseInsensitiveComparer( );
			}

		public int Compare( object x , object y ) {
			int compare_result;
			ListViewItem LX, LY;

			LX = ( ListViewItem ) x;
			LY = ( ListViewItem ) y;

			compare_result = object_compare.Compare( LX.SubItems[column_to_sort].Text , LY.SubItems[column_to_sort].Text );

			if( sort_order == System.Windows.Forms.SortOrder.Ascending ) {
				return compare_result;
				}
			else if( sort_order == System.Windows.Forms.SortOrder.Descending ) {
				return -( compare_result );
				}
			else {
				return 0;
				}
			}

		public int column {
			get {	return column_to_sort; }
			set {	column_to_sort = value;	}
			}

		public System.Windows.Forms.SortOrder order {
			get { return sort_order;	}
			set {	sort_order = value; }
			}
		}
	}