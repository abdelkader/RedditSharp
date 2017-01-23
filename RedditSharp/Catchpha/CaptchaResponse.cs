﻿namespace RedditSharp
{
    public class CaptchaResponse
    {
        /// <summary>
        /// Captcha answer.
        /// </summary>
        public readonly string Answer;

        /// <summary>
        /// Set to true to cancel.
        /// </summary>
        public bool Cancel { get { return string.IsNullOrEmpty(Answer); } }

        public CaptchaResponse(string answer = null)
        {
            Answer = answer;
        }
    }
}
