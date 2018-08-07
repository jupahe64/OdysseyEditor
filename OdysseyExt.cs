﻿using EditorCore;
using EditorCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdysseyExt
{
	class OdysseyExt : ExtensionManifest
	{
		public string ModuleName => "OdysseyEditor";
		public string Author => "Exelix11";
		public string ThanksTo => "KillzXGaming for the C# BFRES loader\r\ngdkchan for Bn" +
								  "Txx\r\nEveryone from masterf0x/RedCarpet";

		public Version TargetVersion => new Version(1, 0, 0, 0);
		
		public IMenuExtension MenuExt => null;

		public IClipboardExtension ClipboardExt => null;

		public bool HasGameModule => true;

		public IGameModule GetNewGameModule() => new OdysseyModule();

		public IFileHander[] Handlers => null;

		const int ReleaseIndex = 2; 
		public void CheckForUpdates()
		{
#if DEBUG
			return;
#endif
			Task.Run(async () => 
			{
				var res = await GitHubUpdateCheck.CheckForUpdates("Exelix11", "OdysseyEditor");
				if (res.Index > ReleaseIndex)
				{
					if (MessageBox.Show("There is a new update for OdysseyEditor !\r\n\r\n" + res.Body + "\r\n\r\n Do you want to open the GitHub page ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
						System.Diagnostics.Process.Start(@"https://github.com/exelix11/OdysseyEditor/releases");
				}
			});
		}
	}
}
