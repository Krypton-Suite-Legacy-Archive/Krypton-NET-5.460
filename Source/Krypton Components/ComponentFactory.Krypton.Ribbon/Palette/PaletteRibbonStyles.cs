﻿// *****************************************************************************
// BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
//  © Component Factory Pty Ltd, 2006 - 2016, All rights reserved.
// The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close, 
//  Mornington, Vic 3931, Australia and are supplied subject to license terms.
// 
//  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2017 - 2020. All rights reserved. (https://github.com/Wagnerp/Krypton-NET-5.460)
//  Version 5.460.0.0  www.ComponentFactory.com
// *****************************************************************************

using System.ComponentModel;
using System.Diagnostics;
using ComponentFactory.Krypton.Toolkit;

namespace ComponentFactory.Krypton.Ribbon
{
    /// <summary>
    /// Implement storage for a ribbon style values.
    /// </summary>
    public class PaletteRibbonStyles : Storage
    {
        #region Instance Fields
        private readonly KryptonRibbon _ribbon;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the PaletteRibbonStyles class.
        /// </summary>
        /// <param name="ribbon">Source ribbon control instance.</param>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        public PaletteRibbonStyles(KryptonRibbon ribbon,
                                   NeedPaintHandler needPaint)
        {
            Debug.Assert(ribbon != null);
            _ribbon = ribbon;

            // Store the provided paint notification delegate
            NeedPaint = needPaint;
        }
        #endregion

        #region IsDefault
        /// <summary>
        /// Gets a value indicating if all values are default.
        /// </summary>
        [Browsable(false)]
        public override bool IsDefault => ((BackStyle == PaletteBackStyle.PanelClient) &&
                                           (GroupButtonStyle == ButtonStyle.ButtonSpec) &&
                                           (GroupClusterButtonStyle == ButtonStyle.Cluster) &&
                                           (GroupDialogButtonStyle == ButtonStyle.ButtonSpec) &&
                                           (GroupCollapsedButtonStyle == ButtonStyle.Alternate) &&
                                           (QATButtonStyle == ButtonStyle.ButtonSpec) &&
                                           (ScrollerStyle == ButtonStyle.Standalone));

        #endregion

        #region BackStyle
        /// <summary>
        /// Gets and sets the ribbon background style.
        /// </summary>
        [Category("Visuals")]
        [Description("Ribbon background style.")]
        [DefaultValue(typeof(PaletteBackStyle), "PanelClient")]
        public PaletteBackStyle BackStyle
        {
            get => _ribbon.BackStyle;
            set => _ribbon.BackStyle = value;
        }
        #endregion

        #region BackInactiveStyle
        /// <summary>
        /// Gets and sets the ribbon background style when owning window is inactive.
        /// </summary>
        [Category("Visuals")]
        [Description("Ribbon background style when owning window is inactive.")]
        [DefaultValue(typeof(PaletteBackStyle), "PanelRibbonInactive")]
        public PaletteBackStyle BackInactiveStyle
        {
            get => _ribbon.BackInactiveStyle;
            set => _ribbon.BackInactiveStyle = value;
        }
        #endregion

        #region GroupButtonStyle
        /// <summary>
        /// Gets and sets the style for buttons insides groups.
        /// </summary>
        [Category("Visuals")]
        [Description("Syle for buttons inside groups.")]
        [DefaultValue(typeof(ButtonStyle), "ButtonSpec")]
        public ButtonStyle GroupButtonStyle
        {
            get => _ribbon.GroupButtonStyle;
            set => _ribbon.GroupButtonStyle = value;
        }
        #endregion

        #region GroupClusterButtonStyle
        /// <summary>
        /// Gets and sets the style for cluster buttons insides groups.
        /// </summary>
        [Category("Visuals")]
        [Description("Syle for cluster buttons inside groups.")]
        [DefaultValue(typeof(ButtonStyle), "Cluster")]
        public ButtonStyle GroupClusterButtonStyle
        {
            get => _ribbon.GroupClusterButtonStyle;
            set => _ribbon.GroupClusterButtonStyle = value;
        }
        #endregion

        #region GroupCollapsedButtonStyle
        /// <summary>
        /// Gets and sets the collapsed group button style.
        /// </summary>
        [Category("Visuals")]
        [Description("Collapsed group button style.")]
        [DefaultValue(typeof(ButtonStyle), "Alternate")]
        public ButtonStyle GroupCollapsedButtonStyle
        {
            get => _ribbon.GroupCollapsedButtonStyle;
            set => _ribbon.GroupCollapsedButtonStyle = value;
        }
        #endregion

        #region GroupDialogButtonStyle
        /// <summary>
        /// Gets and sets the dialog box launcher button style inside groups.
        /// </summary>
        [Category("Visuals")]
        [Description("Dialog box launcher button style inside groups.")]
        [DefaultValue(typeof(ButtonStyle), "ButtonSpec")]
        public ButtonStyle GroupDialogButtonStyle
        {
            get => _ribbon.GroupDialogButtonStyle;
            set => _ribbon.GroupDialogButtonStyle = value;
        }
        #endregion

        #region QATButtonStyle
        /// <summary>
        /// Gets and sets the quick access toolbar button style.
        /// </summary>
        [Category("Visuals")]
        [Description("Quick access toolbar button style.")]
        [DefaultValue(typeof(ButtonStyle), "ButtonSpec")]
        public ButtonStyle QATButtonStyle
        {
            get => _ribbon.QATButtonStyle;
            set => _ribbon.QATButtonStyle = value;
        }
        #endregion

        #region ScrollerStyle
        /// <summary>
        /// Gets and sets the scroller style.
        /// </summary>
        [Category("Visuals")]
        [Description("Panel style.")]
        [DefaultValue(typeof(ButtonStyle), "Standalone")]
        public ButtonStyle ScrollerStyle
        {
            get => _ribbon.ScrollerStyle;
            set => _ribbon.ScrollerStyle = value;
        }
        #endregion
    }
}
