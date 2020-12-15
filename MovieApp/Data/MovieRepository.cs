using MovieApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Data
{
    public static class MovieRepository
    {
        private static List<Movie> _movies = null;
        static MovieRepository()
        {
            _movies = new List<Movie>()
            {
                   new Movie{
                       Id=1,
                       Name="Eternal Sunshine of the Spotless Mind",
                       Description="<p>&nbsp&nbsp&nbspLorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam eu ligula libero.</p><p>&nbsp&nbsp&nbspPraesent sed metus id tortor dapibus rutrum. Nullam quis massa rutrum, tempor mauris id, porttitor magna. Ut quis posuere magna, id vestibulum tellus.Praesent posuere, purus id semper dignissim, justo lorem auctor mauris, non vulputate est ante sed nunc. Nam at viverra purus, a fringilla leo.</p><p>&nbsp&nbsp&nbspivamus mattis, lorem eu hendrerit fringilla, enim dui volutpat ligula, sit amet lobortis felis justo eu nulla. In vitae ante sapien. Morbi rutrum porttitor elit ut pulvinar. Morbi maximus ipsum a leo tempus, vel blandit turpis ullamcorper. Mauris id tincidunt orci, eu viverra mi. Nulla id augue lorem.<p/>",
                       ShortDescription ="<p>&nbsp&nbsp&nbspInteger vel ante enim. Suspendisse ultrices luctus nulla in hendrerit. Curabitur vehicula auctor erat et pellentesque. Interdum et malesuada fames ac ante ipsum primis in faucibus.</p>",
                       Stars="&nbsp&nbsp Jim Carrey, Kate Winslet, Elijah Wood",
                       Director="&nbsp&nbsp Michel Gondry",
                       ImageUrl="1.jpg",
                       CategoryId=4,
                       Status=1},

                   new Movie{
                       Id=2,
                       Name="Avatar",
                       Description="<p>&nbsp&nbsp&nbspLorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam eu ligula libero.</p><p>&nbsp&nbsp&nbspPraesent sed metus id tortor dapibus rutrum. Nullam quis massa rutrum, tempor mauris id, porttitor magna. Ut quis posuere magna, id vestibulum tellus.Praesent posuere, purus id semper dignissim, justo lorem auctor mauris, non vulputate est ante sed nunc. Nam at viverra purus, a fringilla leo.</p><p>&nbsp&nbsp&nbspivamus mattis, lorem eu hendrerit fringilla, enim dui volutpat ligula, sit amet lobortis felis justo eu nulla. In vitae ante sapien. Morbi rutrum porttitor elit ut pulvinar. Morbi maximus ipsum a leo tempus, vel blandit turpis ullamcorper. Mauris id tincidunt orci, eu viverra mi. Nulla id augue lorem.<p/>",
                       ShortDescription ="<p>&nbsp&nbsp&nbspInteger vel ante enim. Suspendisse ultrices luctus nulla in hendrerit. Curabitur vehicula auctor erat et pellentesque. Interdum et malesuada fames ac ante ipsum primis in faucibus.</p>",
                       Stars="&nbsp&nbsp Sam Worthington, Zoe Saldana, Sigourney Weaver",
                       Director="&nbsp&nbsp James Cameron",
                       ImageUrl="2.jpg",
                       CategoryId=2},
                   new Movie{
                       Id=3,
                       Name="Titanic",
                       Description="<p>&nbsp&nbsp&nbspLorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam eu ligula libero.</p><p>&nbsp&nbsp&nbspPraesent sed metus id tortor dapibus rutrum. Nullam quis massa rutrum, tempor mauris id, porttitor magna. Ut quis posuere magna, id vestibulum tellus.Praesent posuere, purus id semper dignissim, justo lorem auctor mauris, non vulputate est ante sed nunc. Nam at viverra purus, a fringilla leo.</p><p>&nbsp&nbsp&nbspivamus mattis, lorem eu hendrerit fringilla, enim dui volutpat ligula, sit amet lobortis felis justo eu nulla. In vitae ante sapien. Morbi rutrum porttitor elit ut pulvinar. Morbi maximus ipsum a leo tempus, vel blandit turpis ullamcorper. Mauris id tincidunt orci, eu viverra mi. Nulla id augue lorem.<p/>",
                       ShortDescription ="<p>&nbsp&nbsp&nbspInteger vel ante enim. Suspendisse ultrices luctus nulla in hendrerit. Curabitur vehicula auctor erat et pellentesque. Interdum et malesuada fames ac ante ipsum primis in faucibus.</p>",
                       Stars="&nbsp&nbsp Leonardo DiCaprio, Kate Winslet, Billy Zane",
                       Director="&nbsp&nbsp James Cameron",
                       ImageUrl="3.jpg",
                       CategoryId=4,
                       Status=1},
                   new Movie{
                       Id=4,
                       Name="Braveheard",
                       Description="<p>&nbsp&nbsp&nbspLorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam eu ligula libero.</p><p>&nbsp&nbsp&nbspPraesent sed metus id tortor dapibus rutrum. Nullam quis massa rutrum, tempor mauris id, porttitor magna. Ut quis posuere magna, id vestibulum tellus.Praesent posuere, purus id semper dignissim, justo lorem auctor mauris, non vulputate est ante sed nunc. Nam at viverra purus, a fringilla leo.</p><p>&nbsp&nbsp&nbspivamus mattis, lorem eu hendrerit fringilla, enim dui volutpat ligula, sit amet lobortis felis justo eu nulla. In vitae ante sapien. Morbi rutrum porttitor elit ut pulvinar. Morbi maximus ipsum a leo tempus, vel blandit turpis ullamcorper. Mauris id tincidunt orci, eu viverra mi. Nulla id augue lorem.<p/>",
                       ShortDescription ="<p>&nbsp&nbsp&nbspInteger vel ante enim. Suspendisse ultrices luctus nulla in hendrerit. Curabitur vehicula auctor erat et pellentesque. Interdum et malesuada fames ac ante ipsum primis in faucibus.</p>",
                       Stars="&nbsp&nbsp Mel Gibson, Sophie Marceau, Patrick McGoohan",
                       Director="&nbsp&nbsp Mel Gibson",
                       ImageUrl="4.jpg",
                       CategoryId=4,
                       Status=1},
                   new Movie{
                       Id=5,
                       Name="Harry Potter Sorcerer's Stone",
                       Description="<p>&nbsp&nbsp&nbspLorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam eu ligula libero.</p><p>&nbsp&nbsp&nbspPraesent sed metus id tortor dapibus rutrum. Nullam quis massa rutrum, tempor mauris id, porttitor magna. Ut quis posuere magna, id vestibulum tellus.Praesent posuere, purus id semper dignissim, justo lorem auctor mauris, non vulputate est ante sed nunc. Nam at viverra purus, a fringilla leo.</p><p>&nbsp&nbsp&nbspivamus mattis, lorem eu hendrerit fringilla, enim dui volutpat ligula, sit amet lobortis felis justo eu nulla. In vitae ante sapien. Morbi rutrum porttitor elit ut pulvinar. Morbi maximus ipsum a leo tempus, vel blandit turpis ullamcorper. Mauris id tincidunt orci, eu viverra mi. Nulla id augue lorem.<p/>",
                       ShortDescription ="<p>&nbsp&nbsp&nbspInteger vel ante enim. Suspendisse ultrices luctus nulla in hendrerit. Curabitur vehicula auctor erat et pellentesque. Interdum et malesuada fames ac ante ipsum primis in faucibus.</p>",
                       Stars="&nbsp&nbsp Daniel Radcliffe, Rupert Grint, Richard Harris",
                       Director="&nbsp&nbsp Chris Columbus",
                       ImageUrl="5.jpg",
                       CategoryId=6,
                       Status=1},
                   new Movie{
                       Id=6,
                       Name="V for Vendetta",
                       Description="<p>&nbsp&nbsp&nbspLorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam eu ligula libero.</p><p>&nbsp&nbsp&nbspPraesent sed metus id tortor dapibus rutrum. Nullam quis massa rutrum, tempor mauris id, porttitor magna. Ut quis posuere magna, id vestibulum tellus.Praesent posuere, purus id semper dignissim, justo lorem auctor mauris, non vulputate est ante sed nunc. Nam at viverra purus, a fringilla leo.</p><p>&nbsp&nbsp&nbspivamus mattis, lorem eu hendrerit fringilla, enim dui volutpat ligula, sit amet lobortis felis justo eu nulla. In vitae ante sapien. Morbi rutrum porttitor elit ut pulvinar. Morbi maximus ipsum a leo tempus, vel blandit turpis ullamcorper. Mauris id tincidunt orci, eu viverra mi. Nulla id augue lorem.<p/>",
                       ShortDescription ="<p>&nbsp&nbsp&nbspInteger vel ante enim. Suspendisse ultrices luctus nulla in hendrerit. Curabitur vehicula auctor erat et pellentesque. Interdum et malesuada fames ac ante ipsum primis in faucibus.</p>",
                       Stars="&nbsp&nbsp Hugo Weaving, Natalie Portman, Rupert Graves",
                       Director="&nbsp&nbsp James McTeigue",
                       ImageUrl="6.jpg",
                       CategoryId=2,
                       Status=1},
                   new Movie{
                       Id=7,
                       Name="Wall-E",
                       Description="<p>&nbsp&nbsp&nbspLorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam eu ligula libero.</p><p>&nbsp&nbsp&nbspPraesent sed metus id tortor dapibus rutrum. Nullam quis massa rutrum, tempor mauris id, porttitor magna. Ut quis posuere magna, id vestibulum tellus.Praesent posuere, purus id semper dignissim, justo lorem auctor mauris, non vulputate est ante sed nunc. Nam at viverra purus, a fringilla leo.</p><p>&nbsp&nbsp&nbspivamus mattis, lorem eu hendrerit fringilla, enim dui volutpat ligula, sit amet lobortis felis justo eu nulla. In vitae ante sapien. Morbi rutrum porttitor elit ut pulvinar. Morbi maximus ipsum a leo tempus, vel blandit turpis ullamcorper. Mauris id tincidunt orci, eu viverra mi. Nulla id augue lorem.<p/>",
                       ShortDescription ="<p>&nbsp&nbsp&nbspInteger vel ante enim. Suspendisse ultrices luctus nulla in hendrerit. Curabitur vehicula auctor erat et pellentesque. Interdum et malesuada fames ac ante ipsum primis in faucibus.</p>",
                       Stars="&nbsp&nbsp Ben Burtt, Elissa Knight, Sigourney Weaver",
                       Director="&nbsp&nbsp Andrew Stanton",
                       ImageUrl="7.jpg",
                       CategoryId=5,
                       Status=1},
                   new Movie{
                       Id=8,
                       Name="Life of Pi",
                       Description="<p>&nbsp&nbsp&nbspLorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam eu ligula libero.</p><p>&nbsp&nbsp&nbspPraesent sed metus id tortor dapibus rutrum. Nullam quis massa rutrum, tempor mauris id, porttitor magna. Ut quis posuere magna, id vestibulum tellus.Praesent posuere, purus id semper dignissim, justo lorem auctor mauris, non vulputate est ante sed nunc. Nam at viverra purus, a fringilla leo.</p><p>&nbsp&nbsp&nbspivamus mattis, lorem eu hendrerit fringilla, enim dui volutpat ligula, sit amet lobortis felis justo eu nulla. In vitae ante sapien. Morbi rutrum porttitor elit ut pulvinar. Morbi maximus ipsum a leo tempus, vel blandit turpis ullamcorper. Mauris id tincidunt orci, eu viverra mi. Nulla id augue lorem.<p/>",
                       ShortDescription ="<p>&nbsp&nbsp&nbspInteger vel ante enim. Suspendisse ultrices luctus nulla in hendrerit. Curabitur vehicula auctor erat et pellentesque. Interdum et malesuada fames ac ante ipsum primis in faucibus.</p>",
                       Stars="&nbsp&nbsp Suraj Sharma, Irrfan Khan, Adil Hussain",
                       Director="&nbsp&nbsp Ang Lee",
                       ImageUrl="8.jpg",
                       CategoryId=2,
                       Status=1},
                   new Movie{
                       Id=9,
                       Name="3 idiots",
                       Description="<p>&nbsp&nbsp&nbspLorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam eu ligula libero.</p><p>&nbsp&nbsp&nbspPraesent sed metus id tortor dapibus rutrum. Nullam quis massa rutrum, tempor mauris id, porttitor magna. Ut quis posuere magna, id vestibulum tellus.Praesent posuere, purus id semper dignissim, justo lorem auctor mauris, non vulputate est ante sed nunc. Nam at viverra purus, a fringilla leo.</p><p>&nbsp&nbsp&nbspivamus mattis, lorem eu hendrerit fringilla, enim dui volutpat ligula, sit amet lobortis felis justo eu nulla. In vitae ante sapien. Morbi rutrum porttitor elit ut pulvinar. Morbi maximus ipsum a leo tempus, vel blandit turpis ullamcorper. Mauris id tincidunt orci, eu viverra mi. Nulla id augue lorem.<p/>",
                       ShortDescription ="<p>&nbsp&nbsp&nbspInteger vel ante enim. Suspendisse ultrices luctus nulla in hendrerit. Curabitur vehicula auctor erat et pellentesque. Interdum et malesuada fames ac ante ipsum primis in faucibus.</p>",
                       Stars="&nbsp&nbsp Aamir Khan, Madhavan, Mona Singh",
                       Director="&nbsp&nbsp Rajkumar Hirani",
                       ImageUrl="9.jpg",
                       CategoryId=3,
                       Status=1}
            };
        }
        public static List<Movie> Movies
        {
            get
            {
                return _movies;
            }
        }
        public static void AddMovie(Movie movie)
        {
            _movies.Add(movie);
        }
        public static Movie GetById(int id)
        {
            return _movies.FirstOrDefault(x => x.Id == id);
        }
    }
}




