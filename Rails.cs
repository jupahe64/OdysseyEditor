﻿using EditorCore.Interfaces;
using ExtensionMethods;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace OdysseyExt
{
	class Rail : LevelObj, IPathObj
	{
		public Point3D[] Points
		{
			get {
				var res = new Point3D[ChildrenObjects.Count];
				for (int i = 0; i < res.Length; i++)
					res[i] = (ChildrenObjects[i].ModelView_Pos).ToPoint3D();
				return res;
			}
			set => throw new NotImplementedException();
		}

		public List<ILevelObj> ChildrenObjects { get; set; } = new List<ILevelObj>();

		public const string N_RailPoints = "RailPoints";

		public Rail(Dictionary<string, dynamic> bymlNode) : base(bymlNode)
		{
			if (Prop.ContainsKey(N_RailPoints))
			{
				foreach (var o in Prop[N_RailPoints])
					ChildrenObjects.Add(new LevelObj(o));
			}
		}

        
        new public Vector3D Pos
        {
            get { return new Vector3D(this[N_Translate]["X"], this[N_Translate]["Y"], this[N_Translate]["Z"]); }
            set
            {
                if (ChildrenObjects.Count>0)
                {
                    //move all path points along so no object movement gets messed up when moved

                    float deltaX = (Single)value.X - this[N_Translate]["X"];
                    float deltaY = (Single)value.Y - this[N_Translate]["Y"];
                    float deltaZ = (Single)value.Z - this[N_Translate]["Z"];

                    foreach (ILevelObj obj in ChildrenObjects)
                    {
                        Vector3D pos = obj.Pos;
                        pos.X += deltaX;
                        pos.Y += deltaY;
                        pos.Z += deltaZ;
                        obj.Pos = pos;
                    }
                }
                this[N_Translate]["X"] = (Single)value.X;
                this[N_Translate]["Y"] = (Single)value.Y;
                this[N_Translate]["Z"] = (Single)value.Z;

            }
        }
        

        //		[Browsable(false)]
        int ILevelObj.ID_int
		{
			get
			{
				int res = -1;
				if (ID.StartsWith("rail"))
					int.TryParse(ID.Substring(4), out res);
				return res;
			}
			set
			{
				ID = "rail" + value.ToString();
			}
		}

		public int Count => ChildrenObjects.Count;
		public bool IsReadOnly => false;
		public ILevelObj this[int index] { get => ChildrenObjects[index]; set => ChildrenObjects[index] = value; }
		public int IndexOf(ILevelObj item) => ChildrenObjects.IndexOf(item);
		public void Insert(int index, ILevelObj item) => ChildrenObjects.Insert(index, item);
		public void RemoveAt(int index) => ChildrenObjects.RemoveAt(index);
		public void Add(ILevelObj item) => ChildrenObjects.Add(item);
		public void Clear() => ChildrenObjects.Clear();
		public bool Contains(ILevelObj item) => ChildrenObjects.Contains(item);
		public void CopyTo(ILevelObj[] array, int arrayIndex) => ChildrenObjects.CopyTo(array,arrayIndex);
		public bool Remove(ILevelObj item) => ChildrenObjects.Remove(item);
		public IEnumerator<ILevelObj> GetEnumerator() => ChildrenObjects.GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator() => ChildrenObjects.GetEnumerator();
		
		public bool IsHidden { get; set; } = false;
		public string name { get => "PathList"; set { } }
		public void ApplyChanges()
		{
			Prop[N_RailPoints].Clear();
			foreach (var o in this) Prop[N_RailPoints].Add(o.Prop);
		}
	}
}
