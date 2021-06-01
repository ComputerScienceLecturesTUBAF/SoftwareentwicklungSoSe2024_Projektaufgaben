using System;
using WikiDotNet;

namespace WikipediaParser
{
    class Program
    {
        static void Main(string[] args)
        {
          string searchString = "Bergakademie";
          WikiSearchSettings searchSettings = new WikiSearchSettings
          	{RequestId = "Request ID", ResultLimit = 5, ResultOffset = 2, Language = "en"};

          WikiSearchResponse response = WikiSearcher.Search(searchString, searchSettings);

          Console.WriteLine($"\nResults found ({searchString}):\n");
          foreach (WikiSearchResult result in response.Query.SearchResults)
          {
          	Console.WriteLine(
          		$"\t{result.Title} ({result.WordCount} words, {result.Size} bytes, id {result.PageId}):\t{result.Preview}...\n\tAt {result.Url(searchSettings.Language)}\n\tLast edited at {result.LastEdited}\n");
          }
        }
    }
}
