using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Exam
{
    static class WriteTags
    {
        public static List<TagsCount> tags = new List<TagsCount>();
        public static string[] libraryOfTags =  {
                "<!--",  "<!DOCTYPE>","<a>", "<abbr>", "<address>",   "<applet>", "<area>","<article>", "<aside>", "<audio>",  "<b>", "<base>","<basefont>",  "<bdo>", "<big>", "<blockquote>","<body>",  "<br>", "<button>",
                "<canvas>", "<caption>","<center>", "<cite>", "<code>","<col>","<colgroup>", "<datalist>", "<dd>","<del>", "<details>", "<dfn>","<dialog>", "<dir>", "<div>", "<dl>", "<dt>", "<em>",  "<embed>","<fieldset>",
                "<figcaption>","<figure>", "<font>","<footer>","<form>", "<frame>","<frameset>", "<h1>","<h2>", "<h3>", "<h4>", "<h5>","<h6>","<head>","<header>","<hgroup>","<hr>","<html>","<i>", "<iframe>", "<img>", "<input>",
                "<ins>", "<kbd>", "<keygen>","<label>", "<legend>",  "<li>","<link>","<main>","<map>", "<mark>", "<menu>", "<menuitem>", "<meta>", "<meter>", "<nav>", "<noscript>", "<object>", "<ol>", "<optgroup>", "<option>",
                "<output>", "<p>",  "<param>","<pre>","<progress>","<q>","<rp>","<rt>","<ruby>", "<s>","<samp>", "<script>", "<section>","<select>","<small>","<source>","<span>","<strike>","<strong>","<style>","<sub>","<summary>",
                "<sup>","<table>","<tbody>", "<td>", "<textarea>", "<tfoot>", "<th>", "<thead>", "<time>", "<title>", "<tr>", "<track>", "<tt>", "<u>", "<ul>","<var>", "<video>", "<wbr>"
        };
        public static List<TagsCount> SetTags(string link)
        {
            try
            {
                WebRequest request = WebRequest.Create(link);
                WebResponse response = request.GetResponse();
                using (Stream stream = response.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        string line = "";
                        while ((line = reader.ReadLine()) != null)
                        {
                            for (int i = 0; i < libraryOfTags.Length; i++)
                            {
                                if (line.Contains(libraryOfTags[i]))
                                {
                                    bool chek = true;
                                    for (int j = 0; j < tags.Count; j++)
                                    {
                                        if (libraryOfTags[i] == tags[j].NameTag) { tags[j].Count++; chek = false; break; }
                                    }
                                    if (chek) { tags.Add(new TagsCount { Count = 1, NameTag = libraryOfTags[i] }); }
                                    break;
                                }
                            }
                        }
                    }
                    response.Close();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return tags;
        }
    }
}
