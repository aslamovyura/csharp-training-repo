﻿using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    /// <summary>
    /// Initialize object of post class.
    /// </summary>
    public class Post
    {
        /// <summary>
        /// Post identifier.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Post title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Post main content.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Publication date.
        /// </summary>
        public DateTime? Date { get; set; }

        /// <summary>
        /// Author identifier.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Author of the post.
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// Identifier of the post topic.
        /// </summary>
        public int TopicId { get; set; }

        /// <summary>
        /// Topic of the post.
        /// </summary>
        public Topic Topic { get; set; }

        /// <summary>
        /// Comments for the topic.
        /// </summary>
        public IList<Comment> Comments { get; set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        public Post()
        {
            Comments = new List<Comment>();
        }
    }
}