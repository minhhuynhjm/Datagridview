﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRManagmentSystem.Common
{
    //public class HMergedCell : DataGridViewTextBoxCell
    //{
    //    private int m_nLeftColumn = 0;
    //    private int m_nRightColumn = 0;

    //    /// <summary>
    //    /// Column Index of the left-most cell to be merged.
    //    /// This cell controls the merged text.
    //    /// </summary>
    //    public int LeftColumn
    //    {
    //        get
    //        {
    //            return m_nLeftColumn;
    //        }
    //        set
    //        {
    //            m_nLeftColumn = value;
    //        }
    //    }

    //    /// <summary>
    //    /// Column Index of the right-most cell to be merged
    //    /// </summary>
    //    public int RightColumn
    //    {
    //        get
    //        {
    //            return m_nRightColumn;
    //        }
    //        set
    //        {
    //            m_nRightColumn = value;
    //        }
    //    }

    //    public int RowIndex { get; set; }

    //    public DataGridView CustomDataGridView { get; set; }

    //    protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates cellState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
    //    {
    //        try
    //        {
    //            int mergeindex = ColumnIndex - m_nLeftColumn;
    //            int i;
    //            int nWidth;
    //            int nWidthLeft;
    //            string strText;

    //            Pen pen = new Pen(Brushes.Black);

    //            // Draw the background
    //            graphics.FillRectangle(new SolidBrush(SystemColors.Control), cellBounds);

    //            // Draw the separator for rows
    //            graphics.DrawLine(new Pen(new SolidBrush(SystemColors.ControlDark)), cellBounds.Left, cellBounds.Bottom - 1, cellBounds.Right, cellBounds.Bottom - 1);

    //            // Draw the right vertical line for the cell
    //            if (ColumnIndex == m_nRightColumn)
    //                graphics.DrawLine(new Pen(new SolidBrush(SystemColors.ControlDark)), cellBounds.Right - 1, cellBounds.Top, cellBounds.Right - 1, cellBounds.Bottom);

    //            // Draw the text
    //            RectangleF rectDest = RectangleF.Empty;
    //            StringFormat sf = new StringFormat();
    //            sf.Alignment = StringAlignment.Center;
    //            sf.LineAlignment = StringAlignment.Center;
    //            sf.Trimming = StringTrimming.EllipsisCharacter;

    //            // Determine the total width of the merged cell
    //            nWidth = 0;
    //            for (i = m_nLeftColumn; i <= m_nRightColumn; i++)
    //                nWidth += this.OwningRow.Cells[i].Size.Width;
    //                //nWidth += CustomDataGridView.Rows[RowIndex].Cells[i].Size.Width;

    //            // Determine the width before the current cell.
    //            nWidthLeft = 0;
    //            for (i = m_nLeftColumn; i < ColumnIndex; i++)
    //                nWidthLeft += this.OwningRow.Cells[i].Size.Width;
    //            //nWidthLeft += CustomDataGridView.Rows[RowIndex].Cells[i].Size.Width;
    //            //var val = this.OwningRow.Cells[m_nLeftColumn].Value.ToString();
    //            // Retrieve the text to be displayed
    //            strText = this.OwningRow.Cells[m_nLeftColumn].Value?.ToString();

    //            rectDest = new RectangleF(cellBounds.Left - nWidthLeft, cellBounds.Top, nWidth, cellBounds.Height);
    //            graphics.DrawString(strText, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, rectDest, sf);
    //        }
    //        catch (Exception ex)
    //        {
    //            // Log 
    //        }
    //    }

    //}// class

    public class HMergedCell : DataGridViewTextBoxCell
    {
        private int m_nLeftColumn = 0;
        private int m_nRightColumn = 0;

        /// <summary>
        /// Column Index of the left-most cell to be merged.
        /// This cell controls the merged text.
        /// </summary>
        public int LeftColumn
        {
            get
            {
                return m_nLeftColumn;
            }
            set
            {
                m_nLeftColumn = value;
            }
        }

        /// <summary>
        /// Column Index of the right-most cell to be merged
        /// </summary>
        public int RightColumn
        {
            get
            {
                return m_nRightColumn;
            }
            set
            {
                m_nRightColumn = value;
            }
        }

        protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates cellState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
        {
            try
            {
                int mergeindex = ColumnIndex - m_nLeftColumn;
                int i;
                int nWidth;
                int nWidthLeft;
                string strText;

                Pen pen = new Pen(Brushes.Black);

                // Draw the background
                graphics.FillRectangle(new SolidBrush(SystemColors.Control), cellBounds);

                // Draw the separator for rows
                graphics.DrawLine(new Pen(new SolidBrush(SystemColors.ControlText)), cellBounds.Left, cellBounds.Bottom - 1, cellBounds.Right, cellBounds.Bottom - 1);

                // Draw the right vertical line for the cell
                if (ColumnIndex == 3)
                    graphics.DrawLine(new Pen(new SolidBrush(SystemColors.ControlText)), cellBounds.Left - 1, cellBounds.Top, cellBounds.Left -1, cellBounds.Bottom);

                if (ColumnIndex == m_nRightColumn)
                    graphics.DrawLine(new Pen(new SolidBrush(SystemColors.ControlText)), cellBounds.Right - 1, cellBounds.Top, cellBounds.Right - 1, cellBounds.Bottom);

                // Draw the text
                RectangleF rectDest = RectangleF.Empty;
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;
                sf.Trimming = StringTrimming.EllipsisCharacter;

                // Determine the total width of the merged cell
                nWidth = 0;
                for (i = m_nLeftColumn; i <= m_nRightColumn; i++)
                    nWidth += this.OwningRow.Cells[i].Size.Width;

                // Determine the width before the current cell.
                nWidthLeft = 0;
                for (i = m_nLeftColumn; i < ColumnIndex; i++)
                    nWidthLeft += this.OwningRow.Cells[i].Size.Width;

                // Retrieve the text to be displayed
                strText = this.OwningRow.Cells[m_nLeftColumn].Value.ToString();

                rectDest = new RectangleF(cellBounds.Left - nWidthLeft, cellBounds.Top, nWidth, cellBounds.Height);
                graphics.DrawString(strText, new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular), Brushes.Black, rectDest, sf);

                //graphics.DrawString(strText, new Font(this.OwningRow.Cells[m_nLeftColumn].Style., this.OwningRow.Cells[m_nLeftColumn].Style.Font.Size), Brushes.Black, rectDest, sf);
            }
            catch (Exception ex)
            {
               
            }
        }

    }// class
}
