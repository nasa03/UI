// =======================================================================================
// UITooltip
// by Weaver (Fhiz)
// MIT licensed
//
// 
//
// =======================================================================================

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using wovencode;

namespace wovencode
{
	
	// ===================================================================================
	// UITooltip
	// ===================================================================================
	public class UITooltip : UIBase
	{
		
		public Text tooltipText;
		
		public static UITooltip singleton;
		
		
		// -------------------------------------------------------------------------------
		// Awake
		// -------------------------------------------------------------------------------
		protected override void Awake()
		{
			if (singleton == null) singleton = this;
			base.Awake();
		}
		
		// -------------------------------------------------------------------------------
		// 
		// -------------------------------------------------------------------------------
		public void Show(string _text)
		{
			tooltipText.text = _text;
			base.Show();
		}
		
		// -------------------------------------------------------------------------------
		// UpdateTooltip
		// -------------------------------------------------------------------------------
		public void UpdateTooltip(string _text)
		{
			if (root.activeSelf)
				tooltipText.text = _text;
		
		}
		
		
	}
	
	// -----------------------------------------------------------------------------------
	
}

// =======================================================================================