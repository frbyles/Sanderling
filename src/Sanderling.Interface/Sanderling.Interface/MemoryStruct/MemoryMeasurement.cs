﻿using System;

namespace Sanderling.Interface.MemoryStruct
{
	/// <summary>
	/// Root of the graph of objects read from memory that is delivered from the sensor to the consuming application.
	/// </summary>
	public interface IMemoryMeasurement
	{
		string VersionString { get; }

		IMenu[] Menu { get; }

		IShipUi ShipUi { get; }

		IShipUiTarget[] Target { get; }

		/// <summary>
		/// shown when hovering mouse cursor over module.
		/// </summary>
		IContainer ModuleButtonTooltip { get; }

		/// <summary>
		/// Occludes all other UIElements and can usually be opened and closed by pressing ESC.
		/// </summary>
		IWindow SystemMenu { get; }

		INeocom Neocom { get; }

		IUIElement InfoPanelButtonCurrentSystem { get; }

		IUIElement InfoPanelButtonRoute { get; }

		IUIElement InfoPanelButtonMissions { get; }

		IUIElement InfoPanelButtonIncursions { get; }

		InfoPanelCurrentSystem InfoPanelCurrentSystem { get; }

		InfoPanelRoute InfoPanelRoute { get; }

		InfoPanelMissions InfoPanelMissions { get; }

		IContainer[] Utilmenu { get; }

		IUIElementText[] AbovemainMessage { get; }

		PanelGroup[] AbovemainPanelGroup { get; }

		PanelGroup[] AbovemainPanelEveMenu { get; }

		IWindow[] WindowOther { get; }

		WindowStack[] WindowStack { get; }

		IWindowOverview[] WindowOverview { get; }

		WindowChatChannel[] WindowChatChannel { get; }

		IWindowSelectedItemView[] WindowSelectedItemView { get; }

		IWindowDroneView[] WindowDroneView { get; }

		WindowPeopleAndPlaces[] WindowPeopleAndPlaces { get; }

		IWindowStation[] WindowStation { get; }

		WindowShipFitting[] WindowShipFitting { get; }

		WindowFittingMgmt[] WindowFittingMgmt { get; }

		IWindowSurveyScanView[] WindowSurveyScanView { get; }

		IWindowInventory[] WindowInventory { get; }

		IWindowAgentDialogue[] WindowAgentDialogue { get; }

		WindowAgentBrowser[] WindowAgentBrowser { get; }

		WindowTelecom[] WindowTelecom { get; }

		WindowRegionalMarket[] WindowRegionalMarket { get; }

		WindowMarketAction[] WindowMarketAction { get; }

		WindowItemSell[] WindowItemSell { get; }

	}

	public class MemoryMeasurement : IMemoryMeasurement, ICloneable
	{
		public string VersionString { set; get; }

		public IMenu[] Menu { set; get; }

		public IShipUi ShipUi { set; get; }

		public IShipUiTarget[] Target { set; get; }

		public IContainer ModuleButtonTooltip { set; get; }

		public IWindow SystemMenu { set; get; }

		public INeocom Neocom { set; get; }

		public IUIElement InfoPanelButtonCurrentSystem { set; get; }

		public IUIElement InfoPanelButtonRoute { set; get; }

		public IUIElement InfoPanelButtonMissions { set; get; }

		public IUIElement InfoPanelButtonIncursions { set; get; }

		public InfoPanelCurrentSystem InfoPanelCurrentSystem { set; get; }

		public InfoPanelRoute InfoPanelRoute { set; get; }

		public InfoPanelMissions InfoPanelMissions { set; get; }

		public IContainer[] Utilmenu { set; get; }

		public IUIElementText[] AbovemainMessage { set; get; }

		public PanelGroup[] AbovemainPanelGroup { set; get; }

		public PanelGroup[] AbovemainPanelEveMenu { set; get; }

		public IWindow[] WindowOther { set; get; }

		public WindowStack[] WindowStack { set; get; }

		public IWindowOverview[] WindowOverview { set; get; }

		public WindowChatChannel[] WindowChatChannel { set; get; }

		public IWindowSelectedItemView[] WindowSelectedItemView { set; get; }

		public IWindowDroneView[] WindowDroneView { set; get; }

		public WindowPeopleAndPlaces[] WindowPeopleAndPlaces { set; get; }

		public IWindowStation[] WindowStation { set; get; }

		public WindowShipFitting[] WindowShipFitting { set; get; }

		public WindowFittingMgmt[] WindowFittingMgmt { set; get; }

		public IWindowSurveyScanView[] WindowSurveyScanView { set; get; }

		public IWindowInventory[] WindowInventory { set; get; }

		public IWindowAgentDialogue[] WindowAgentDialogue { set; get; }

		public WindowAgentBrowser[] WindowAgentBrowser { set; get; }

		public WindowTelecom[] WindowTelecom { set; get; }

		public WindowRegionalMarket[] WindowRegionalMarket { set; get; }

		public WindowMarketAction[] WindowMarketAction { set; get; }

		public WindowItemSell[] WindowItemSell { set; get; }

		public MemoryMeasurement Copy() => this.CopyByPolicyMemoryMeasurement();

		public object Clone() => Copy();
	}
}
