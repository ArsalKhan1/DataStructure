/// <summary>
/// The namespace for Article class
/// </summary>
namespace reuseRepo
{
    /// <summary>
    /// A article object that holds title, author and tags
    /// </summary>
    /// <remarks>
    /// Part of /Diagram/Article.drawio project
    /// </remarks>
    public class Article
    {

        /// <summary>
        /// Stores the title property of an article
        /// </summary>
        private string title = "";

        /// <summary>
        /// Stores the author property of an article
        /// </summary>
        private string author = "";

        /// <summary>
        /// Stores the author property of an article
        /// </summary>
        private double price = 0;

        /// <summary>
        /// Stores all the tags associated with an article
        /// </summary>
        private Tag[] tags = new Tag[] { };

        /// <summary>
        /// The class constructor
        /// </summary>
        /// <param name="title"> Initial title of the article</param>
        /// <param name="author"> Initial author of the article</param>
        /// <param name="price"> Initial price of the article</param>
        /// <param name="tags"> Initial array of tags of the article</param>
        public Article(string title, string author, double price, Tag[] tags)
        {
            this.title = title;
            this.author = author;
            this.price = price;
            this.tags = new Tag[tags.Length];
            tags.CopyTo(this.tags, 0);
        }

        /// <summary>
        /// Returns the tags of an article
        /// </summary>
        /// <returns> The tags are an array of objects of type Tag </returns>
        public Tag[] getTags()
        {
            return this.tags;
        }


        /// <summary>
        /// Returns the title of an article
        /// </summary>
        /// <returns> The title is a string </returns>
        public string getTitle()
        {
            return this.title;
        }

        /// <summary>
        /// Returns the author of an article
        /// </summary>
        /// <returns> The author is a string </returns>
        public string getAuthor()
        {
            return this.author;
        }

        /// <summary>
        /// Returns the price of an article
        /// </summary>
        /// <returns> The price is double/currency </returns>
        public double getPrice()
        {
            return this.price;
        }

        /// <summary>
        /// Set or change the price of an article
        /// </summary>
        /// <param name="price"> The price is float/currency </param>
        public void setPrice(double price)
        {
            this.price = price;
        }
    }
}
