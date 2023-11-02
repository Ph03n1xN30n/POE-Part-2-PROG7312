using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeweyDecimalApplication
{
    
    public class BookManager
    {
       //Storing Single Book in Each Panel 
        private Panel bookPanels;
        private List<Book> books;
        private List<Panel> bookHolders;

        public BookManager()
        {
               
            bookPanels = new Panel();
            bookHolders = new List<Panel>();
            books = new List<Book>();
            GenerateBooks();
        }
//=================================================================================
        private List<Book> GenerateBooks()
        {
          Random random = new Random(); 
            List<Book> generatedBooks = new List<Book>();

            for(int i = 0; i <= 10; i++)
            {
                Book book = new Book
                {
                    BookPanel = new Panel(),
                    //Generated Value Stored In Book Class
                    CallNumber = "Generate Random Number"
                };

                //
                book.BookPanel.Size = new System.Drawing.Size(100, 200);
                book.BookPanel.BackColor = Color.White;
                book.BookPanel.BorderStyle = BorderStyle.FixedSingle;

                //
                book.BookPanel.MouseDown += BookPanel_MouseDown;
                book.BookPanel.MouseMove += BookPanel_MouseMove;
                book.BookPanel.MouseUp += BookPanel_MouseUp;

                Label label = new Label()
                {
                   Text = book.CallNumber,
                   AutoSize = true,
                   AllowDrop = true,
                   Tag = book,
                   Visible = true
                };

                //
                book.BookPanel.Controls.Add(label); 

                //
                books.Add(book);    
            }
            return generatedBooks;
        }
//======================================================================================
        private Point offset;

        private Book currentBook = null;

//=============================================================================
        private void BookPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if(currentBook != null)
            {
                currentBook = null;
            }
        }
//========================================================================================
        private void BookPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(currentBook != null)
            {
                Point newLocation = bookPanels.PointToClient(e.Location);
                newLocation.Offset(-offset.X, -offset.Y);
                currentBook.BookPanel.Location = newLocation;
            }
        }
//========================================================================================
        private void BookPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Panel bookPanel = (Panel)sender;
                currentBook = books.FirstOrDefault(book => book.BookPanel == bookPanel);

                if (currentBook != null)
                {
                    offset = new Point(e.X, e.Y);
                }
            }
        }

//=================================================================================
        public void DisplayBooks(Panel panel)
        {
            panel.Controls.Clear();

            foreach(Book book in books)
            {
                Label label = book.BookLabel;
                panel.Controls.Add(label);
            }
        }
//==================================================================================
public void AddBookHolder(Panel bookHolder)
        {
            bookHolders.Add(bookHolder);
            bookHolder.DragEnter += BookHolder_DragEnter;
            bookHolder.DragDrop += BookHolder_DragDrop;

        }
//====================================================================================
        private void BookHolder_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Book)))
            {
                Book book = (Book)e.Data.GetData(typeof(Book));
                Panel cardHolder = (Panel)sender;

                // Move the card to the card holder
                cardHolder.Controls.Add(book.BookLabel);
            }
        }
//====================================================================================
        private void BookHolder_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
//==============================================================================
    }
}
