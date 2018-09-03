using EditorCore.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdysseyExt
{
	public partial class StageSelectionForm : Form 
	{
		public string Result = null;

		public StageSelectionForm()
		{
			InitializeComponent();

			#region treeview
			treeView1.Nodes.Add(ContainerLevel("Cap Kingdom", "CapWorldHomeStage",
				Level("Top-Hat Tower", "CapWorldTowerStage"),
				Folder("Sub rooms",
					Level("Poison Tides","PoisonWaveExStage"),
					Level("Push-Blocks", "PushBlockExStage"),
					Level("Frog Pound", "FrogSearchExStage"),
					Level("Rolling Lane", "RollingExStage")
				)
			));
			treeView1.Nodes.Add(ContainerLevel("Cascade Kingdom", "WaterfallWorldHomeStage",
				Folder("Sub rooms",
					Level("T-Rex Nest", "TrexPoppunExStage"),
					Level("ChainChomp", "WanwanClashExStage"),
					Level("Chasm Lifts", "Lift2DExStage"),
					Level("Mysterious Clouds", "CapAppearExStage"),
					Level("Gusty Bridges", "WindBlowExStage")
				)
			));
			treeView1.Nodes.Add(ContainerLevel("Sand Kingdom", "SandWorldHomeStage",
				Level("Town", "SandWorldHomeTownZone"),
				Level("Round Tower", "SandWorldKillerTowerZone"),
				Level("Shop", "SandWorldShopStage"),
				Level("Slots", "SandWorldSlotStage"),
				Level("Costume Needed: Dancing", "SandWorldCostumeStage"),
				Level("Sphynx Treasure Vault", "SandWorldSecretStage"),
				Level("Vibration Room", "SandWorldVibrationStage"),
				Level("Inverted Pyramid: Lower Interior", "SandWorldPyramid000Stage"),
				Level("Inverted Pyramid: Upper Interior", "SandWorldPyramid001Stage"),
				Level("Cave below the Pyramid", "SandWorldUnderground000Stage"),
				Level("KnuckleTec Boss Arena", "SandWorldUnderground001Stage"),
				Folder("Sub rooms",
					Level("Ice Cave", "SandWorldPressExStage"),
					Level("Moe-Eye Invisible Maze", "SandWorldMeganeExStage"),
					Level("Bullet Bill Maze", "SandWorldKillerExStage"),
					Level("Jaxi Ruins", "SandWorldSphinxExStage"),
					Level("Rotating Houses", "SandWorldRotateExStage"),
					Level("Moe-Eye Invisible Floor", "MeganeLiftExStage"),
					Level("Colossal Ruins", "RocketFlowerExStage"),
					Level("Freezing Waterway", "WaterTubeExStage")
				)
			));
			treeView1.Nodes.Add(ContainerLevel("Lake Kingdom", "LakeWorldHomeStage",
				Level("Town", "LakeWorldTownZone"),
				Level("8-bit Section", "LakeWorld2DZone"),
				Level("Shop", "LakeWorldShopStage"),
				Level("Timer Challenge 2", "LakeWorldTimerAthletic000Zone"),
				Folder("Sub rooms",
					Level("Statue Puzzle", "GotogotonExStage"),
					Level("Zipper Chasm", "FastenerExStage"),
					Level("Bouncy Flowers", "TrampolineWallCatchExStage"),
					Level("Poison Swamp", "FrogPoisonExStage")
				)
			));
			#endregion
		}

		#region treeview
		private static TreeNode Level(string name, string internalName)
		{
			var tn = new TreeNode(name);
			tn.Tag = internalName;
			return tn;
		}
		private static TreeNode Folder(string name, params TreeNode[] children)
		{
			var tn = new TreeNode(name, children);
			return tn;
		}
		private static TreeNode ContainerLevel(string name, string internalName, params TreeNode[] children)
		{
			var tn = new TreeNode(name,children);
			tn.Tag = internalName;
			return tn;
		}
		#endregion

		private void button2_Click(object sender, EventArgs e)
		{
			Result = null;
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (treeView1.SelectedNode == null)
			{
				MessageBox.Show("Select a level");
				return;
			}
			Result = treeView1.SelectedNode.Tag as string;
			this.Close();
		}

		private void treeView1_DoubleClick(object sender, EventArgs e)
		{
			if (treeView1.SelectedNode == null)
				return;
			Result = treeView1.SelectedNode.Tag as string;
			this.Close();
		}
	}
}
