using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RepositoryPattern_Repository
{
    public class StreamingContentRepository
    {
        private List<StreamingContent> _listOfContent = new List<StreamingContent>();
       
        //Create 
        public void AddContentToList(StreamingContent content) //first method, doesn't return anything
        {
            _listOfContent.Add(content); //anything with underscore_ is a field
         //   ListOfContent //this is a property
        }

        //Read
        public List<StreamingContent> GetContentList() //return type: list
        {
            return _listOfContent; //when call method GetContentList, get field _listOfContent
        }


        //Update
        public bool UpdateExistingContent(string originalTitle, StreamingContent newContent)
        {
            //Find the content
            StreamingContent oldContent = GetContentByTitle(originalTitle);

            //Update the content
            if(oldContent != null)
            {
                oldContent.Title = newContent.Title;
                oldContent.Description = newContent.Description;
                oldContent.MaturityRating = newContent.MaturityRating;
                oldContent.IsFamilyFriendly = newContent.IsFamilyFriendly;
                oldContent.StarRating = newContent.StarRating;
                oldContent.TypeOfGenre = newContent.TypeOfGenre;
                return true;
            }
            else
            {
                return false;
            }
        }


        //Delete
        public bool RemoveContentFromList(string title)
        {
            StreamingContent content = GetContentByTitle(title);
            if (content == null)
            {
                return false;
            }

            int initialCount = _listOfContent.Count;
            _listOfContent.Remove(content);

            if (initialCount > _listOfContent.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //Helper method //this method is only to help other methods, can't be accessed outside if set to private
        public StreamingContent GetContentByTitle(string title)
        {
            foreach(StreamingContent content in _listOfContent)
            {
                if(content.Title == title)
                {
                    return content;
                }
            }

            return null;

        }

    }
}
