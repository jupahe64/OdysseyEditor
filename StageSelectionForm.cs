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
		public string StageName => treeView1.SelectedNode.Tag as string;

		public string StageType => comboBox1.SelectedItem as string;

		public StageSelectionForm()
		{
			InitializeComponent();

			comboBox1.SelectedIndex = 0;

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
				Level("8-bit Tower", "SandWorldKillerTowerZone"),
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
			treeView1.Nodes.Add(ContainerLevel("Wodded Kingdom", "ForestWorldHomeStage",
				Level("Deep Woods", "ForestWorldWoodsStage"),
				Level("Sky Garden Tower", "ForestWorldTowerStage"),
				Level("8-bit Section", "ForestWorld2DRoadZone"),
				Level("2D Athletics", "ForestWorldAthleticZone"),
				Level("Timer Challenge 2", "ForestWorldTimerAthletic001Zone"),
				Level("Costume Needed: Treasure in the Deep Woods", "ForestWorldWoodsCostumeStage"),
				Level("Deep Woods: Treasure Vault", "ForestWorldWoodsTreasureStage"),
				Level("Torkdrift Boss Arena", "ForestWorldBossStage"),
				Level("Spinning-Platforms Treasure Vault", "ForestWorldBonusStage"),
				Folder("Sub rooms",
					Level("Flooding Pipeway", "ForestWorldWaterExStage"),
					Level("Fog Wandering", "FogMountainExStage"),
					Level("Flower Road", "RailCollisionExStage"),
					Level("Sherm Elevator", "ShootingElevatorExStage"),
					Level("Walking on Clouds", "ForestWorldCloudBonusExStage"),
					Level("Invisible Road", "PackunPoisonExStage"),
					Level("Sheep Herding", "AnimalChaseExStage"),
					Level("Breakdown Road", "KillerRoadExStage")
				)
			));
			treeView1.Nodes.Add(ContainerLevel("Cloud Kingdom", "CloudWorldHomeStage",
				Level("Goomba Picture Puzzle", "FukuwaraiKuriboStage"),
				Folder("Sub rooms",
					Level("King of the Cube", "Cube2DExStage")
				)
			));
			treeView1.Nodes.Add(ContainerLevel("Lost Kingdom", "ClashWorldHomeStage",
				Level("Shop", "ClashWorldShopStage"),
				Folder("Sub rooms",
					Level("Tropical Wiggler Swamp", "ImomuPoisonExStage"),
					Level("Klepto Lava Bath", "JangoExStage")
				)
			));
			treeView1.Nodes.Add(ContainerLevel("Metro Kingdom", "CityWorldHomeStage",
				Level("Timer Challenge 1", "CityWorldTimerAthletic000Zone"),
				Level("Timer Challenge 3", "CityWorldTimerAthletic002Zone"),
				Level("Timer Challenge 4", "CityWorldTimerAthletic003Zone"),
				Folder("8-bit Festival",
					Level("Barrel Avoid Section", "CityWorld2DSign000Zone"),
					Level("Barrel Avoid Section 2", "CityWorld2DSign001Zone"),
					Level("Gravity Flip Section", "CityWorld2DSign002Zone"),
					Level("Upside Down Section", "CityWorld2DSign003Zone"),
					Level("Secret", "CityWorld2DSign004Zone"),
					Level("Coin fall Section", "CityWorld2DSign005Zone"),
					Level("DK Fight Section", "CityWorld2DSign006Zone")
				),
				Folder("Sub rooms",
					Level("RC Race", "RadioControlExStage"),
					Level("Rainbow Notes", "Note2D3DRoomExStage"),
					Level("Projection Room(smb 1-1)", "Theater2DExStage"),
					Level("Crowded Street", "CityPeopleRoadStage"),
					Level("Electric Wire", "ElectricWireExStage"),
					Level("Sherm Siege", "ShootingCityExStage"),
					Level("Rotating Maze", "CapRotatePackunExStage"),
					Level("Pole Jumping", "PoleGrabCeilExStage"),
					Level("Bullet Building", "PoleKillerExStage"),
					Level("T-Rex Escape", "TrexBikeExStage"),
					Level("Scaling Pitch Black Mountain", "DonsukeExStage"),
					Level("Swinging Scaffolding", "SwingSteelExStage"),
					Level("Vanishing Road", "BikeSteelExStage")
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

		private void treeView1_DoubleClick(object sender, EventArgs e)
		{
			button1.PerformClick();
		}
	}
}
