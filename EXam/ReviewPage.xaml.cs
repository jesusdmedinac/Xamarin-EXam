﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace EXam
{
    public partial class ReviewPage : ContentPage
    {
        public ReviewPage(ReviewPageViewModel rpvm)
        {
            InitializeComponent();

            BindingContext = rpvm;

            listQuestions.ItemTapped += OnListÌtemTapped;
        }

        private void OnListÌtemTapped(object sender, ItemTappedEventArgs e) {
            var qqvm = (QuizQuestionViewModel)e.Item;

            if (qqvm != null) {
                this.DisplayAlert("Explanation", qqvm.Explanation, "OK");
            }
        }
    }
}
