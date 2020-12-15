using MovieApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Data
{
    public static class SeriesRepository
    {
        private static List<Series> _series = null;
        static SeriesRepository()
        {
            _series = new List<Series>()
            {
             new Series{
                       Id=1,
                       Name="Peaky Blinders",
                       Description="<p>&nbsp&nbsp&nbspLorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam eu ligula libero.</p><p>&nbsp&nbsp&nbspPraesent sed metus id tortor dapibus rutrum. Nullam quis massa rutrum, tempor mauris id, porttitor magna. Ut quis posuere magna, id vestibulum tellus.Praesent posuere, purus id semper dignissim, justo lorem auctor mauris, non vulputate est ante sed nunc. Nam at viverra purus, a fringilla leo.</p><p>&nbsp&nbsp&nbspivamus mattis, lorem eu hendrerit fringilla, enim dui volutpat ligula, sit amet lobortis felis justo eu nulla. In vitae ante sapien. Morbi rutrum porttitor elit ut pulvinar. Morbi maximus ipsum a leo tempus, vel blandit turpis ullamcorper. Mauris id tincidunt orci, eu viverra mi. Nulla id augue lorem.<p/>",
                       ShortDescription ="<p>&nbsp&nbsp&nbspInteger vel ante enim. Suspendisse ultrices luctus nulla in hendrerit. Curabitur vehicula auctor erat et pellentesque. Interdum et malesuada fames ac ante ipsum primis in faucibus.</p>",
                       Stars="&nbsp&nbsp Cillian Murphy, Paul Anderson, Helen McCrory",
                       Director="&nbsp&nbsp Steven Knight",
                       ImageUrl="Series1.jpg",
                       CategoryId=3,
                       Status=2},

                   new Series{
                       Id=2,
                       Name="You",
                       Description="<p>&nbsp&nbsp&nbspLorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam eu ligula libero.</p><p>&nbsp&nbsp&nbspPraesent sed metus id tortor dapibus rutrum. Nullam quis massa rutrum, tempor mauris id, porttitor magna. Ut quis posuere magna, id vestibulum tellus.Praesent posuere, purus id semper dignissim, justo lorem auctor mauris, non vulputate est ante sed nunc. Nam at viverra purus, a fringilla leo.</p><p>&nbsp&nbsp&nbspivamus mattis, lorem eu hendrerit fringilla, enim dui volutpat ligula, sit amet lobortis felis justo eu nulla. In vitae ante sapien. Morbi rutrum porttitor elit ut pulvinar. Morbi maximus ipsum a leo tempus, vel blandit turpis ullamcorper. Mauris id tincidunt orci, eu viverra mi. Nulla id augue lorem.<p/>",
                       ShortDescription ="<p>&nbsp&nbsp&nbspInteger vel ante enim. Suspendisse ultrices luctus nulla in hendrerit. Curabitur vehicula auctor erat et pellentesque. Interdum et malesuada fames ac ante ipsum primis in faucibus.</p>",
                       Stars="&nbsp&nbsp Sam Worthington, Zoe Saldana, Sigourney Weaver",
                       Director="&nbsp&nbsp  Penn Badgley, Victoria Pedretti, Ambyr Childers",
                       ImageUrl="Series2.jpg",
                       CategoryId=2,
                       Status=2},
                   new Series{
                       Id=3,
                       Name="Lucifer",
                       Description="<p>&nbsp&nbsp&nbspLorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam eu ligula libero.</p><p>&nbsp&nbsp&nbspPraesent sed metus id tortor dapibus rutrum. Nullam quis massa rutrum, tempor mauris id, porttitor magna. Ut quis posuere magna, id vestibulum tellus.Praesent posuere, purus id semper dignissim, justo lorem auctor mauris, non vulputate est ante sed nunc. Nam at viverra purus, a fringilla leo.</p><p>&nbsp&nbsp&nbspivamus mattis, lorem eu hendrerit fringilla, enim dui volutpat ligula, sit amet lobortis felis justo eu nulla. In vitae ante sapien. Morbi rutrum porttitor elit ut pulvinar. Morbi maximus ipsum a leo tempus, vel blandit turpis ullamcorper. Mauris id tincidunt orci, eu viverra mi. Nulla id augue lorem.<p/>",
                       ShortDescription ="<p>&nbsp&nbsp&nbspInteger vel ante enim. Suspendisse ultrices luctus nulla in hendrerit. Curabitur vehicula auctor erat et pellentesque. Interdum et malesuada fames ac ante ipsum primis in faucibus.</p>",
                       Stars="&nbsp&nbsp  Tom Ellis, Lauren German, Kevin Alejandro",
                       Director="&nbsp&nbsp Tom Kapinos",
                       ImageUrl="Series3.jpg",
                       CategoryId=4,
                       Status=2},
                   new Series{
                       Id=4,
                       Name="Vikings",
                       Description="<p>&nbsp&nbsp&nbspLorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam eu ligula libero.</p><p>&nbsp&nbsp&nbspPraesent sed metus id tortor dapibus rutrum. Nullam quis massa rutrum, tempor mauris id, porttitor magna. Ut quis posuere magna, id vestibulum tellus.Praesent posuere, purus id semper dignissim, justo lorem auctor mauris, non vulputate est ante sed nunc. Nam at viverra purus, a fringilla leo.</p><p>&nbsp&nbsp&nbspivamus mattis, lorem eu hendrerit fringilla, enim dui volutpat ligula, sit amet lobortis felis justo eu nulla. In vitae ante sapien. Morbi rutrum porttitor elit ut pulvinar. Morbi maximus ipsum a leo tempus, vel blandit turpis ullamcorper. Mauris id tincidunt orci, eu viverra mi. Nulla id augue lorem.<p/>",
                       ShortDescription ="<p>&nbsp&nbsp&nbspInteger vel ante enim. Suspendisse ultrices luctus nulla in hendrerit. Curabitur vehicula auctor erat et pellentesque. Interdum et malesuada fames ac ante ipsum primis in faucibus.</p>",
                       Stars="&nbsp&nbsp  Katheryn Winnick, Gustaf Skarsgård, Alexander Ludwig",
                       Director="&nbsp&nbsp Michael Hirst",
                       ImageUrl="Series4.jpg",
                       CategoryId=3,
                       Status=2},
                   new Series{
                       Id=5,
                       Name="Punisher",
                       Description="<p>&nbsp&nbsp&nbspLorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam eu ligula libero.</p><p>&nbsp&nbsp&nbspPraesent sed metus id tortor dapibus rutrum. Nullam quis massa rutrum, tempor mauris id, porttitor magna. Ut quis posuere magna, id vestibulum tellus.Praesent posuere, purus id semper dignissim, justo lorem auctor mauris, non vulputate est ante sed nunc. Nam at viverra purus, a fringilla leo.</p><p>&nbsp&nbsp&nbspivamus mattis, lorem eu hendrerit fringilla, enim dui volutpat ligula, sit amet lobortis felis justo eu nulla. In vitae ante sapien. Morbi rutrum porttitor elit ut pulvinar. Morbi maximus ipsum a leo tempus, vel blandit turpis ullamcorper. Mauris id tincidunt orci, eu viverra mi. Nulla id augue lorem.<p/>",
                       ShortDescription ="<p>&nbsp&nbsp&nbspInteger vel ante enim. Suspendisse ultrices luctus nulla in hendrerit. Curabitur vehicula auctor erat et pellentesque. Interdum et malesuada fames ac ante ipsum primis in faucibus.</p>",
                       Stars="&nbsp&nbsp  Jon Bernthal, Amber Rose Revah, Ben Barnes",
                       Director="&nbsp&nbsp Steve Lightfoot",
                       ImageUrl="Series5.jpg",
                       CategoryId=3,
                       Status=2},
                   new Series{
                       Id=6,
                       Name="Cursed",
                       Description="<p>&nbsp&nbsp&nbspLorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam eu ligula libero.</p><p>&nbsp&nbsp&nbspPraesent sed metus id tortor dapibus rutrum. Nullam quis massa rutrum, tempor mauris id, porttitor magna. Ut quis posuere magna, id vestibulum tellus.Praesent posuere, purus id semper dignissim, justo lorem auctor mauris, non vulputate est ante sed nunc. Nam at viverra purus, a fringilla leo.</p><p>&nbsp&nbsp&nbspivamus mattis, lorem eu hendrerit fringilla, enim dui volutpat ligula, sit amet lobortis felis justo eu nulla. In vitae ante sapien. Morbi rutrum porttitor elit ut pulvinar. Morbi maximus ipsum a leo tempus, vel blandit turpis ullamcorper. Mauris id tincidunt orci, eu viverra mi. Nulla id augue lorem.<p/>",
                       ShortDescription ="<p>&nbsp&nbsp&nbspInteger vel ante enim. Suspendisse ultrices luctus nulla in hendrerit. Curabitur vehicula auctor erat et pellentesque. Interdum et malesuada fames ac ante ipsum primis in faucibus.</p>",
                       Stars="&nbsp&nbsp Katherine Langford, Devon Terrell, Gustaf Skarsgård",
                       Director="&nbsp&nbsp Frank Miller, Tom Wheeler",
                       ImageUrl="Series6.jpg",
                       CategoryId=4,
                       Status=2},
                   new Series{
                       Id=7,
                       Name="Arrow",
                       Description="<p>&nbsp&nbsp&nbspLorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam eu ligula libero.</p><p>&nbsp&nbsp&nbspPraesent sed metus id tortor dapibus rutrum. Nullam quis massa rutrum, tempor mauris id, porttitor magna. Ut quis posuere magna, id vestibulum tellus.Praesent posuere, purus id semper dignissim, justo lorem auctor mauris, non vulputate est ante sed nunc. Nam at viverra purus, a fringilla leo.</p><p>&nbsp&nbsp&nbspivamus mattis, lorem eu hendrerit fringilla, enim dui volutpat ligula, sit amet lobortis felis justo eu nulla. In vitae ante sapien. Morbi rutrum porttitor elit ut pulvinar. Morbi maximus ipsum a leo tempus, vel blandit turpis ullamcorper. Mauris id tincidunt orci, eu viverra mi. Nulla id augue lorem.<p/>",
                       ShortDescription ="<p>&nbsp&nbsp&nbspInteger vel ante enim. Suspendisse ultrices luctus nulla in hendrerit. Curabitur vehicula auctor erat et pellentesque. Interdum et malesuada fames ac ante ipsum primis in faucibus.</p>",
                       Stars="&nbsp&nbsp  Stephen Amell, Katie Cassidy, David Ramsey",
                       Director="&nbsp&nbsp Greg Berlanti, Marc Guggenheim, Andrew Kreisberg",
                       ImageUrl="Series7.jpg",
                       CategoryId=3,
                       Status=2},
                   new Series{
                       Id=8,
                       Name="Dark",
                       Description="<p>&nbsp&nbsp&nbspLorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam eu ligula libero.</p><p>&nbsp&nbsp&nbspPraesent sed metus id tortor dapibus rutrum. Nullam quis massa rutrum, tempor mauris id, porttitor magna. Ut quis posuere magna, id vestibulum tellus.Praesent posuere, purus id semper dignissim, justo lorem auctor mauris, non vulputate est ante sed nunc. Nam at viverra purus, a fringilla leo.</p><p>&nbsp&nbsp&nbspivamus mattis, lorem eu hendrerit fringilla, enim dui volutpat ligula, sit amet lobortis felis justo eu nulla. In vitae ante sapien. Morbi rutrum porttitor elit ut pulvinar. Morbi maximus ipsum a leo tempus, vel blandit turpis ullamcorper. Mauris id tincidunt orci, eu viverra mi. Nulla id augue lorem.<p/>",
                       ShortDescription ="<p>&nbsp&nbsp&nbspInteger vel ante enim. Suspendisse ultrices luctus nulla in hendrerit. Curabitur vehicula auctor erat et pellentesque. Interdum et malesuada fames ac ante ipsum primis in faucibus.</p>",
                       Stars="&nbsp&nbsp  Louis Hofmann, Karoline Eichhorn, Lisa Vicari",
                       Director="&nbsp&nbsp Baran bo Odar, Jantje Friese",
                       ImageUrl="Series8.jpg",
                       CategoryId=3,
                       Status=2},
                   new Series{
                       Id=9,
                       Name="The Last Kingdom",
                       Description="<p>&nbsp&nbsp&nbspLorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam eu ligula libero.</p><p>&nbsp&nbsp&nbspPraesent sed metus id tortor dapibus rutrum. Nullam quis massa rutrum, tempor mauris id, porttitor magna. Ut quis posuere magna, id vestibulum tellus.Praesent posuere, purus id semper dignissim, justo lorem auctor mauris, non vulputate est ante sed nunc. Nam at viverra purus, a fringilla leo.</p><p>&nbsp&nbsp&nbspivamus mattis, lorem eu hendrerit fringilla, enim dui volutpat ligula, sit amet lobortis felis justo eu nulla. In vitae ante sapien. Morbi rutrum porttitor elit ut pulvinar. Morbi maximus ipsum a leo tempus, vel blandit turpis ullamcorper. Mauris id tincidunt orci, eu viverra mi. Nulla id augue lorem.<p/>",
                       ShortDescription ="<p>&nbsp&nbsp&nbspInteger vel ante enim. Suspendisse ultrices luctus nulla in hendrerit. Curabitur vehicula auctor erat et pellentesque. Interdum et malesuada fames ac ante ipsum primis in faucibus.</p>",
                       Stars="&nbsp&nbsp Alexander Dreymon, Eliza Butterworth, Ian Hart",
                       Director="&nbsp&nbsp  Peter Hoar",
                       ImageUrl="Series9.jpg",
                       CategoryId=3,
                       Status=2}
            };
        }
        public static List<Series> Series
        {
            get
            {
                return _series;
            }
        }
        public static void AddSeries(Series series)
        {
            _series.Add(series);
        }
        public static Series GetById(int id)
        {
            return _series.FirstOrDefault(x => x.Id == id);
        }
    }
}




