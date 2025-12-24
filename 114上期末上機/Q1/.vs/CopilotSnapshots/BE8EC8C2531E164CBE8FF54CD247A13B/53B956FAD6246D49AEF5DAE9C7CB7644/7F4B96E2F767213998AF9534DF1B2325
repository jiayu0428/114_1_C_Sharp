using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Q1
{
    public partial class Form1 : Form
    {
        private enum Move { Stone = 0, Paper = 1, Scissors = 2 }

        private int playerWins = 0;
        private int computerWins = 0;
        private Random rng = new Random();

        private Image stoneImage;
        private Image paperImage;
        private Image scissorsImage;

        // separate images for computer (user-specified absolute paths)
        private Image compStoneImage;
        private Image compPaperImage;
        private Image compScissorsImage;

        private Move lastComputerMove;

        public Form1()
        {
            InitializeComponent();
            CreateMoveImages();
            UpdateScoreLabels();
        }

        // 初始化三張玩家圖片與三張電腦圖片（電腦與玩家圖片皆來自絕對路徑）
        private void CreateMoveImages()
        {
            // Dispose existing images if any
            stoneImage?.Dispose();
            paperImage?.Dispose();
            scissorsImage?.Dispose();
            compStoneImage?.Dispose();
            compPaperImage?.Dispose();
            compScissorsImage?.Dispose();

            // Prepare fallback drawn images (used if file missing)
            var fallbackStone = DrawCircleBitmap(Color.Gray, "石");
            var fallbackPaper = DrawRectangleBitmap(Color.WhiteSmoke, "布");
            var fallbackScissors = DrawScissorsBitmap(Color.Silver, "剪");

            // Load computer images from provided absolute file paths; fallback to drawn images if missing
            try
            {
                string compPaperPath = @"C:\Users\m303\Desktop\114_1_C_Sharp\114上期末上機\IMAGE\paper_computer.png";
                string compScissorPath = @"C:\Users\m303\Desktop\114_1_C_Sharp\114上期末上機\IMAGE\scissor_computer.png";
                string compStonePath = @"C:\Users\m303\Desktop\114_1_C_Sharp\114上期末上機\IMAGE\stone_computer.png";

                var rawCompPaper = LoadImageSafe(compPaperPath);
                var rawCompScissors = LoadImageSafe(compScissorPath);
                var rawCompStone = LoadImageSafe(compStonePath);

                // Determine target size from computer picture box (fallback to 200x200)
                Size compTarget = new Size(200, 200);
                if (computerPictureBox != null && computerPictureBox.ClientSize.Width > 0)
                {
                    compTarget = computerPictureBox.ClientSize;
                }

                compPaperImage = rawCompPaper != null ? ResizeImage(rawCompPaper, compTarget) : ResizeImage(fallbackPaper, compTarget);
                compScissorsImage = rawCompScissors != null ? ResizeImage(rawCompScissors, compTarget) : ResizeImage(fallbackScissors, compTarget);
                compStoneImage = rawCompStone != null ? ResizeImage(rawCompStone, compTarget) : ResizeImage(fallbackStone, compTarget);

                rawCompPaper?.Dispose();
                rawCompScissors?.Dispose();
                rawCompStone?.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("載入電腦圖片時發生錯誤: " + ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Size compTarget = computerPictureBox != null ? computerPictureBox.ClientSize : new Size(200, 200);
                compPaperImage = ResizeImage(fallbackPaper, compTarget);
                compScissorsImage = ResizeImage(fallbackScissors, compTarget);
                compStoneImage = ResizeImage(fallbackStone, compTarget);
            }

            // Load player images from provided absolute file paths; fallback to drawn images if missing
            try
            {
                string playerPaperPath = @"C:\Users\m303\Desktop\114_1_C_Sharp\114上期末上機\IMAGE\paper_player.png";
                string playerScissorPath = @"C:\Users\m303\Desktop\114_1_C_Sharp\114上期末上機\IMAGE\scissor_player.png";
                string playerStonePath = @"C:\Users\m303\Desktop\114_1_C_Sharp\114上期末上機\IMAGE\stone_player.png";

                var rawPlayerPaper = LoadImageSafe(playerPaperPath);
                var rawPlayerScissors = LoadImageSafe(playerScissorPath);
                var rawPlayerStone = LoadImageSafe(playerStonePath);

                // Determine target size from player picture box (fallback to 200x200)
                Size playerTarget = new Size(200, 200);
                if (playerPictureBox != null && playerPictureBox.ClientSize.Width > 0)
                {
                    playerTarget = playerPictureBox.ClientSize;
                }

                paperImage = rawPlayerPaper != null ? ResizeImage(rawPlayerPaper, playerTarget) : ResizeImage(fallbackPaper, playerTarget);
                scissorsImage = rawPlayerScissors != null ? ResizeImage(rawPlayerScissors, playerTarget) : ResizeImage(fallbackScissors, playerTarget);
                stoneImage = rawPlayerStone != null ? ResizeImage(rawPlayerStone, playerTarget) : ResizeImage(fallbackStone, playerTarget);

                rawPlayerPaper?.Dispose();
                rawPlayerScissors?.Dispose();
                rawPlayerStone?.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("載入玩家圖片時發生錯誤: " + ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Size playerTarget = playerPictureBox != null ? playerPictureBox.ClientSize : new Size(200, 200);
                paperImage = ResizeImage(fallbackPaper, playerTarget);
                scissorsImage = ResizeImage(fallbackScissors, playerTarget);
                stoneImage = ResizeImage(fallbackStone, playerTarget);
            }

            // dispose fallbacks
            fallbackStone.Dispose();
            fallbackPaper.Dispose();
            fallbackScissors.Dispose();
        }

        // Resize image to fit target while preserving aspect ratio and centering on white background
        private Image ResizeImage(Image src, Size targetSize)
        {
            if (src == null) return null;
            int tw = Math.Max(1, targetSize.Width);
            int th = Math.Max(1, targetSize.Height);

            float ratio = Math.Min((float)tw / src.Width, (float)th / src.Height);
            int nw = (int)(src.Width * ratio);
            int nh = (int)(src.Height * ratio);

            var dest = new Bitmap(tw, th);
            using (var g = Graphics.FromImage(dest))
            {
                g.Clear(Color.White);
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                int x = (tw - nw) / 2;
                int y = (th - nh) / 2;
                g.DrawImage(src, x, y, nw, nh);
            }
            return dest;
        }

        // 載入圖片且不鎖定原始檔案
        private Image LoadImageSafe(string path)
        {
            if (string.IsNullOrEmpty(path)) return null;
            if (!File.Exists(path)) return null;
            try
            {
                byte[] bytes = File.ReadAllBytes(path);
                using (var ms = new MemoryStream(bytes))
                {
                    return Image.FromStream(ms);
                }
            }
            catch
            {
                return null;
            }
        }

        // 電腦選擇邏輯模組
        private Move getCompChoice()
        {
            lastComputerMove = (Move)rng.Next(0, 3);
            return lastComputerMove;
        }

        // 根據電腦選擇顯示圖片（使用指定的電腦圖片）
        private void showComputerImage(Move m)
        {
            switch (m)
            {
                case Move.Stone:
                    computerPictureBox.Image = compStoneImage;
                    break;
                case Move.Paper:
                    computerPictureBox.Image = compPaperImage;
                    break;
                case Move.Scissors:
                    computerPictureBox.Image = compScissorsImage;
                    break;
            }
        }

        // 根據玩家選擇顯示圖片
        private void showPlayerImage(Move m)
        {
            playerPictureBox.Image = GetImageForMove(m);
        }

        // 判斷勝負、更新分數及結果顯示
        private void showWinner(Move playerMove, Move computerMove)
        {
            int result = CompareMoves(playerMove, computerMove);
            if (result == 1)
            {
                playerWins++;
                resultLabel.Text = "玩家獲勝！";
            }
            else if (result == -1)
            {
                computerWins++;
                resultLabel.Text = "電腦獲勝！";
            }
            else
            {
                resultLabel.Text = "平手！";
            }

            UpdateScoreLabels();
        }

        private Bitmap DrawCircleBitmap(Color back, string text)
        {
            var bmp = new Bitmap(200, 200);
            using (var g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
                using (var b = new SolidBrush(back))
                {
                    g.FillEllipse(b, 30, 30, 140, 140);
                }
                using (var sf = new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
                using (var f = new Font("Microsoft Sans Serif", 36, FontStyle.Bold))
                using (var b = new SolidBrush(Color.Black))
                {
                    g.DrawString(text, f, b, new RectangleF(0, 0, 200, 200), sf);
                }
            }
            return bmp;
        }

        private Bitmap DrawRectangleBitmap(Color back, string text)
        {
            var bmp = new Bitmap(200, 200);
            using (var g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
                using (var b = new SolidBrush(back))
                {
                    g.FillRectangle(b, 30, 30, 140, 140);
                }
                using (var sf = new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
                using (var f = new Font("Microsoft Sans Serif", 36, FontStyle.Bold))
                using (var b = new SolidBrush(Color.Black))
                {
                    g.DrawString(text, f, b, new RectangleF(0, 0, 200, 200), sf);
                }
            }
            return bmp;
        }

        private Bitmap DrawScissorsBitmap(Color color, string text)
        {
            var bmp = new Bitmap(200, 200);
            using (var g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
                using (var pen = new Pen(color, 8))
                {
                    g.DrawLine(pen, 50, 50, 150, 150);
                    g.DrawLine(pen, 150, 50, 50, 150);
                }
                using (var sf = new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
                using (var f = new Font("Microsoft Sans Serif", 32, FontStyle.Bold))
                using (var b = new SolidBrush(Color.Black))
                {
                    g.DrawString(text, f, b, new RectangleF(0, 0, 200, 200), sf);
                }
            }
            return bmp;
        }

        private void stoneButton_Click(object sender, EventArgs e)
        {
            PlayRound(Move.Stone);
        }

        private void paperButton_Click(object sender, EventArgs e)
        {
            PlayRound(Move.Paper);
        }

        private void scissorsButton_Click(object sender, EventArgs e)
        {
            PlayRound(Move.Scissors);
        }

        private void PlayRound(Move playerMove)
        {
            // 取得電腦出拳
            Move comp = getCompChoice();

            // 顯示雙方圖片
            showPlayerImage(playerMove);
            showComputerImage(comp);

            // 判斷並顯示勝者
            showWinner(playerMove, comp);
        }

        private Image GetImageForMove(Move m)
        {
            switch (m)
            {
                case Move.Stone: return stoneImage;
                case Move.Paper: return paperImage;
                case Move.Scissors: return scissorsImage;
                default: return null;
            }
        }

        // returns 1 if a beats b, -1 if b beats a, 0 if tie
        private int CompareMoves(Move a, Move b)
        {
            if (a == b) return 0;
            // stone beats scissors, scissors beats paper, paper beats stone
            if ((a == Move.Stone && b == Move.Scissors) ||
                (a == Move.Scissors && b == Move.Paper) ||
                (a == Move.Paper && b == Move.Stone))
                return 1;
            return -1;
        }

        private void UpdateScoreLabels()
        {
            playerScoreLabel.Text = $"玩家：{playerWins} 勝";
            computerScoreLabel.Text = $"電腦：{computerWins} 勝";
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            playerWins = 0;
            computerWins = 0;
            // 釋放電腦動態載入的圖片（若有）
            compPaperImage?.Dispose();
            compScissorsImage?.Dispose();
            compStoneImage?.Dispose();

            playerPictureBox.Image = null;
            computerPictureBox.Image = null;
            resultLabel.Text = "已重置，請開始新一輪遊戲。";
            UpdateScoreLabels();
            stoneButton.Enabled = true;
            paperButton.Enabled = true;
            scissorsButton.Enabled = true;

            // 重新載入（若需要）
            CreateMoveImages();
        }

        private void endButton_Click(object sender, EventArgs e)
        {
            string summary = $"遊戲結束\n玩家勝場：{playerWins}\n電腦勝場：{computerWins}";
            MessageBox.Show(summary, "遊戲統計", MessageBoxButtons.OK, MessageBoxIcon.Information);
            stoneButton.Enabled = false;
            paperButton.Enabled = false;
            scissorsButton.Enabled = false;
        }

        // 在 Form 載入時初始化介面
        private void Form1_Load(object sender, EventArgs e)
        {
            playerPictureBox.Image = null;
            computerPictureBox.Image = null;
            resultLabel.Text = "請出拳：選擇 石頭 / 布 / 剪刀";
            UpdateScoreLabels();
        }

        private void computerPictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
