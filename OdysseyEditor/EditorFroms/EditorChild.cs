﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdysseyEditor.EditorFroms
{
	interface IEditorChild
	{
		EditorForm ParentEditor { get; set; }
	}
}