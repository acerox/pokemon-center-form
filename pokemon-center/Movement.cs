using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pokemon_center
{
    class Movement
    {
        private Form form;

        private int mousePositionX;
        private int mousePositionY;
        private bool windowState = false;

        public Movement(Form form)
        {
            this.form = form;
        }

        public void setMouseMovement(int x, int y, Boolean windowState)
        {
            mousePositionX = x;
            mousePositionY = y;
            this.windowState = windowState;
        }

        public Boolean isMoving()
        {
            return windowState;
        }

        public void setWindowState(bool v)
        {
            windowState = v;
        }

        public Point getWindowPoint()
        {
            return new Point(
                Cursor.Position.X - form.Location.X - mousePositionX,
                Cursor.Position.Y - form.Location.Y - mousePositionY);
        }

        internal void changeWindowPosition()
        {
            if (isMoving())
            {
                form.Location = form.PointToScreen(getWindowPoint());
            }
        }
    }
}
