﻿using System;

namespace WebAPIDoodle.Entity {

    public class OAuthCredential {

        private readonly string _consumerKey;
        private readonly string _consumerSecret;
        private readonly string _token;
        private readonly string _tokenSecret;

        public OAuthCredential(string consumerKey, string consumerSecret, string token, string tokenSecret) {

            if (string.IsNullOrEmpty(consumerKey)) {
                throw new ArgumentNullException("consumerKey");
            }

            if (string.IsNullOrEmpty(consumerSecret)) {
                throw new ArgumentNullException("consumerSecret");
            }

            if (string.IsNullOrEmpty(token)) {
                throw new ArgumentNullException(token);
            }

            if (string.IsNullOrEmpty(tokenSecret)) {
                throw new ArgumentNullException(tokenSecret);
            }

            _consumerKey = consumerKey;
            _consumerSecret = consumerSecret;
            _token = token;
            _tokenSecret = tokenSecret;
        }

        public string ConsumerKey { 

            get {
                return _consumerKey;
            } 
        }
        
        public string ConsumerSecret {

            get {
                return _consumerSecret;
            }
        }

        public string Token {

            get {
                return _token;
            } 
        }

        public string TokenSecret {
            
            get {
                return _tokenSecret;
            }
        }
    }
}