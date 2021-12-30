using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;

namespace TO_DO_LIST {
	static class Program {
		/// <summary>
		/// Der Haupteinstiegspunkt für die Anwendung.
		/// </summary>
		[STAThread]
		static void Main( ) {
			Application.EnableVisualStyles( );
			Application.SetCompatibleTextRenderingDefault( false );
			Application.Run( new Overview( ) );
			}
		}

	public static class Global {
		public static int ID;
		
		public static string sub_task_title;
		public static bool sub_task_new;
		public static int sub_task_id;

		public static int link_id;
		public static bool link_new;
		}

	public static class ModifyProgressBarColor {
		[DllImport( "user32.dll" , CharSet = CharSet.Auto , SetLastError = false )]
		static extern IntPtr SendMessage( IntPtr hWnd , uint Msg , IntPtr w , IntPtr l );
		public static void SetState( this ProgressBar pBar , int state ) {
			SendMessage( pBar.Handle , 1040 , ( IntPtr ) state , IntPtr.Zero );
			}
		}
 }