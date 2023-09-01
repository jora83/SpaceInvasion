namespace SpaceInvasion.Scripts
{
    public class Star
    {
        public int PosX { get; set; }
        public int PosY { get; set; }
        public int Speed { get; set; }
        public PictureBox PictureBox { get; set; }

        public Star(int posX, int posY, int speed, Image image)
        {
            PosX = posX;
            PosY = posY;
            Speed = speed;

            PictureBox = new PictureBox
            {
                Location = new Point(PosX, PosY),
                Size = new Size(Constants.StarWidth, Constants.StarHeight),
                Image = image
            };
        }

        public void Move()
        {
            PosY += Speed;
            PictureBox.Top = PosY;
        }
    }
}
