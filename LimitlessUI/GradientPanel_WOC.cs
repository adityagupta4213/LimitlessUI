﻿using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;


public partial class GradientPanel_WOC : Panel
{
    Color _startColor = Color.WhiteSmoke;
    Color _endColor = Color.SteelBlue;

    float _angle = 90;

    public GradientPanel_WOC()
    {
        DoubleBuffered = true;
    }

    protected override void OnPaint(PaintEventArgs pe)
    {
        base.OnPaint(pe);
        LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                                                             _startColor,
                                                             _endColor,
                                                             _angle);
        pe.Graphics.FillRectangle(brush, this.ClientRectangle);
    }

    public float Angle
    {
        get { return _angle; }
        set
        {
            _angle = value;
            Invalidate();
        }
    }
    public Color StartColor
    {
        get { return _startColor; }
        set
        {
            _startColor = value;
            Invalidate();
        }
    }

    public Color EndColor
    {
        get { return _endColor; }
        set
        {
            _endColor = value;
            Invalidate();
        }
    }
}

