using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MovieLibraryApplication.BUS;

namespace MovieLibraryApplication
{
    public partial class MovieLibraryForm : Form
    {
        List<Movie> myMovieList = new List<Movie>();
        int index;
        static String path = @"../../DATA/MovieInfos.txt";
        static String filepath = @"../../DATA/MovieBinary.bin";
        
        public MovieLibraryForm()
        {
            InitializeComponent();
        }

        public static void ValidateLetter(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                MessageBox.Show(" Must be a letter only \nMessage from ValidateLetter operation..");
                e.Handled = true;
            }
        }
        public static void ValidateDigit(KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                MessageBox.Show(" Must be a digit only  \n Message from ValidateDigit operation..");
                e.Handled = true;
            }
        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            listViewMovieLibrary.Items.Clear();
            if (this.myMovieList.Capacity != 0)
            {
                foreach (Movie element in this.myMovieList)
                {
                    ListViewItem Item = new ListViewItem(element.Movietitle);
                    Item.SubItems.Add(Convert.ToString(element.Type));
                    Item.SubItems.Add(element.Director);
                    Item.SubItems.Add(Convert.ToString(element.Duration.ToString()));
                    Item.SubItems.Add(element.Country);
                    Item.SubItems.Add(Convert.ToString(element.Year));
                    Item.SubItems.Add(Convert.ToString(element.Language));
                    Item.SubItems.Add(element.Actor);
                    Item.SubItems.Add(Convert.ToString(element.Subtitle));
                    Item.SubItems.Add(element.Awards);
                    listViewMovieLibrary.Items.Add(Item);
                    
                }

            }
            else
            {
                MessageBox.Show(" Not Data Found ");
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxMovieTitle.Text = "";
            textBoxHour.Text = "";
            textBoxMinute.Text = "";
            textBoxSecond.Text = "";
            comboBoxType.Text = Convert.ToString(EnumMovieType.None);
            textBoxCountry.Text = "";
            textBoxDirector.Text = "";
            textBoxYear.Text = "";
            comboBoxLanguage.Text = Convert.ToString(EnumMovieLanguage.None);
            comboBoxSubtitles.Text = Convert.ToString(EnumMovieSubtitle.None);
            textBoxAct.Text = "";
            textBoxAwards.Text = "";
            textBoxMovieTitle.Focus();
            listViewMovieLibrary.Items.Clear();
            textBoxSearch.Text = "";
        }

        private void MovieLibraryForm_Load(object sender, EventArgs e)
        {
            foreach ( EnumMovieType element in Enum.GetValues (typeof(EnumMovieType)))
            {
                comboBoxType.Items.Add(element);
            }
            comboBoxType.Text = Convert.ToString(comboBoxType.Items[0]);

            foreach (EnumMovieLanguage element in Enum.GetValues(typeof(EnumMovieLanguage)))
            {
                comboBoxLanguage.Items.Add(element);
            }
            comboBoxLanguage.Text = Convert.ToString(comboBoxLanguage.Items[0]);

            foreach (EnumMovieSubtitle element in Enum.GetValues(typeof(EnumMovieSubtitle)))
            {
                comboBoxSubtitles.Items.Add(element);
            }
            comboBoxSubtitles.Text = Convert.ToString(comboBoxSubtitles.Items[0]);

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Movie aMovie = new Movie();
            String input;
            string movietitle;
            EnumMovieType type;
            string country;
            string director;
            int year;
            EnumMovieLanguage language;
            EnumMovieSubtitle subtitle;
            string actor;
            string awards;

            input = textBoxMovieTitle.Text;
            movietitle = Convert.ToString(input);
            input = textBoxHour.Text;
            type = (EnumMovieType)comboBoxType.SelectedIndex;
            input = textBoxCountry.Text;
            country = Convert.ToString(input);
            input = textBoxDirector.Text;
            director = Convert.ToString(input);
            input = textBoxYear.Text;
            year = Convert.ToInt32(input);
            language = (EnumMovieLanguage)comboBoxLanguage.SelectedIndex;
            subtitle = (EnumMovieSubtitle)comboBoxSubtitles.SelectedIndex;
            input = textBoxAct.Text;
            actor = Convert.ToString(input);
            input = textBoxAwards.Text;
            awards = Convert.ToString(input);

            Time aTime = new Time();
            aTime.Hour = Convert.ToInt32(textBoxHour.Text);
            aTime.Minute = Convert.ToInt32(textBoxMinute.Text);
            aTime.Second = Convert.ToInt32(textBoxSecond.Text);
            aMovie.Duration = aTime;

            aMovie.Movietitle = movietitle;
            aMovie.Type = type;
            aMovie.Country = country;
            aMovie.Director = director;
            aMovie.Year = year;
            aMovie.Language = language;
            aMovie.Subtitle = subtitle;
            aMovie.Actor = actor;
            aMovie.Awards = awards;
            this.myMovieList.Add(aMovie);



    }


        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We are updating your movie " + index);

            this.myMovieList[index].Movietitle = Convert.ToString(textBoxMovieTitle.Text);
            this.myMovieList[index].Duration.Hour = Convert.ToInt32(textBoxHour.Text);
            this.myMovieList[index].Duration.Minute = Convert.ToInt32(textBoxMinute.Text);
            this.myMovieList[index].Duration.Second = Convert.ToInt32(textBoxSecond.Text);
            this.myMovieList[index].Type = (EnumMovieType)comboBoxType.SelectedIndex;
            this.myMovieList[index].Country = Convert.ToString(textBoxCountry.Text);
            this.myMovieList[index].Director = Convert.ToString(textBoxDirector.Text);
            this.myMovieList[index].Year = Convert.ToInt32(textBoxYear.Text);
            this.myMovieList[index].Language = (EnumMovieLanguage)comboBoxType.SelectedIndex;
            this.myMovieList[index].Subtitle = (EnumMovieSubtitle)comboBoxType.SelectedIndex;
            this.myMovieList[index].Actor = Convert.ToString(textBoxAct.Text);
            this.myMovieList[index].Awards = Convert.ToString(textBoxAwards.Text);

            MessageBox.Show(" Movie Updated");
            this.listViewMovieLibrary.Items.Clear();
            foreach (Movie element in this.myMovieList)
            {
                ListViewItem Item = new ListViewItem(element.Movietitle);
                Item.SubItems.Add(Convert.ToString(element.Type));
                Item.SubItems.Add(element.Director);
                Item.SubItems.Add(Convert.ToString(element.Duration.ToString()));
                Item.SubItems.Add(element.Country);
                Item.SubItems.Add(Convert.ToString(element.Year));
                Item.SubItems.Add(Convert.ToString(element.Language));
                Item.SubItems.Add(element.Actor);
                Item.SubItems.Add(Convert.ToString(element.Subtitle));
                Item.SubItems.Add(element.Awards);
                listViewMovieLibrary.Items.Add(Item);

            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            this.myMovieList.RemoveAt(index);
            this.listViewMovieLibrary.Items.Clear();
            foreach (Movie aMovie in this.myMovieList)
            {
                this.listViewMovieLibrary.Items.Add(aMovie.GetInfos());
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            bool find = false;
            Movie theMovie = new Movie();

            foreach (Movie element in this.myMovieList)
            {
                if ( element.Movietitle == Convert.ToString (textBoxSearch.Text))
                {
                    find = true;
                    theMovie = element;
                }
            }
            if(find)
            {
                MessageBox.Show("Movie found" + theMovie.GetInfos());
            }
            else
            {
                MessageBox.Show("Movie did not find");
            }
        }

        private void textBoxYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateDigit(e);
        }

        private void textBoxCountry_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateLetter(e);
        }

        private void textBoxDuration_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateDigit(e);
        }

        private void listViewMovieLibrary_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = listViewMovieLibrary.FocusedItem.Index;
            MessageBox.Show("Selected : " + index);
            textBoxMovieTitle.Text = Convert.ToString(this.myMovieList[index].Movietitle);
            textBoxHour.Text = Convert.ToString(this.myMovieList[index].Duration.Hour);
            textBoxMinute.Text = Convert.ToString(this.myMovieList[index].Duration.Minute);
            textBoxSecond.Text = Convert.ToString(this.myMovieList[index].Duration.Second);
            comboBoxType.Text = Convert.ToString(this.myMovieList[index].Type);
            textBoxCountry.Text = Convert.ToString(this.myMovieList[index].Country);
            textBoxDirector.Text = Convert.ToString(this.myMovieList[index].Director);
            textBoxYear.Text = Convert.ToString(this.myMovieList[index].Year);
            comboBoxLanguage.Text = Convert.ToString(this.myMovieList[index].Language);
            comboBoxSubtitles.Text = Convert.ToString(this.myMovieList[index].Subtitle);
            textBoxAct.Text = Convert.ToString(this.myMovieList[index].Actor);
            textBoxAwards.Text = Convert.ToString(this.myMovieList[index].Awards);
        }

        private void buttonWriteText_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = File.CreateText(path))
            {
                foreach (Movie aMovie in this.myMovieList)
                {

                    writer.WriteLine(aMovie.Movietitle + "|" + aMovie.Type + "|" + aMovie.Director+"|"+aMovie.Duration.Hour + "|" + aMovie.Duration.Minute + "|" + aMovie.Duration.Second + "|" +aMovie.Country+"|"+aMovie.Year+"|"+aMovie.Language+"|"+aMovie.Actor+"|"+aMovie.Subtitle+"|"+aMovie.Awards);
                }
            }
        }

        private void buttonReadText_Click(object sender, EventArgs e)
        {
            myMovieList.Clear();
            this.listViewMovieLibrary.Items.Clear();

            StreamReader reader = new StreamReader(path);

            String line = null;
            while ((line = reader.ReadLine()) != null)
            {
                Movie aMovie = new Movie();
                String[] tokens = line.Split('|');
                aMovie.Movietitle = Convert.ToString(tokens[0]);
                aMovie.Type = (EnumMovieType)Enum.Parse(typeof(EnumMovieType), tokens[1]);
                aMovie.Director = Convert.ToString(tokens[2]);

                Time aTime = new Time();
                aTime.Hour = Convert.ToInt32(tokens[3]);
                aTime.Minute = Convert.ToInt32(tokens[4]);
                aTime.Second= Convert.ToInt32(tokens[5]);

                aMovie.Duration = aTime;
                aMovie.Country = Convert.ToString(tokens[6]);
                aMovie.Year = Convert.ToInt32(tokens[7]);
                aMovie.Language = (EnumMovieLanguage)Enum.Parse(typeof(EnumMovieLanguage), tokens[8]);
                aMovie.Actor = Convert.ToString(tokens[9]);
                aMovie.Subtitle = (EnumMovieSubtitle)Enum.Parse(typeof(EnumMovieSubtitle), tokens[10]);
                aMovie.Awards = Convert.ToString(tokens[11]);
                myMovieList.Add(aMovie);
            }

            foreach (Movie element in this.myMovieList)
            {
                ListViewItem Item = new ListViewItem(element.Movietitle);
                Item.SubItems.Add(Convert.ToString(element.Type));
                Item.SubItems.Add(element.Director);
                Item.SubItems.Add(Convert.ToString(element.Duration.ToString()));
                Item.SubItems.Add(element.Country);
                Item.SubItems.Add(Convert.ToString(element.Year));
                Item.SubItems.Add(Convert.ToString(element.Language));
                Item.SubItems.Add(element.Actor);
                Item.SubItems.Add(Convert.ToString(element.Subtitle));
                Item.SubItems.Add(element.Awards);
                listViewMovieLibrary.Items.Add(Item);

            }
            reader.Close();
        }

        private void buttonWriteBinaryFile_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter bin = new BinaryFormatter();
            foreach(Movie aMovie in this.myMovieList)
            {
                bin.Serialize(fs, aMovie);
            }
            fs.Close();

        }

        private void buttonReadBinaryFile_Click(object sender, EventArgs e)
        {
            myMovieList.Clear();
            this.listViewMovieLibrary.Items.Clear();
            if (File.Exists(filepath))
            {
                FileStream fs = new FileStream(filepath, FileMode.Open, FileAccess.Read);
                BinaryFormatter bin = new BinaryFormatter();
                while(fs.Position < fs.Length)
                {
                    Movie aMovie = new Movie();
                    aMovie = (Movie)bin.Deserialize(fs);
                    myMovieList.Add(aMovie);                   
                }
                fs.Close();
                foreach (Movie element in this.myMovieList)
                {
                    ListViewItem Item = new ListViewItem(element.Movietitle);
                    Item.SubItems.Add(Convert.ToString(element.Type));
                    Item.SubItems.Add(element.Director);
                    Item.SubItems.Add(Convert.ToString(element.Duration.ToString()));
                    Item.SubItems.Add(element.Country);
                    Item.SubItems.Add(Convert.ToString(element.Year));
                    Item.SubItems.Add(Convert.ToString(element.Language));
                    Item.SubItems.Add(element.Actor);
                    Item.SubItems.Add(Convert.ToString(element.Subtitle));
                    Item.SubItems.Add(element.Awards);
                    listViewMovieLibrary.Items.Add(Item);

                }
            }
        }
    }
    
}
