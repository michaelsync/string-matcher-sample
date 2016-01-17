using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace TextMatcher.Core.Tests
{
    public abstract class TextMatchingEngineTestsBase
    {
        protected abstract ITextMatchingEngine CreateEngine();

        private const string Text = "Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea";
        [Fact(DisplayName = "The ArgumentNull exception is thrown when the Text parameter of TextMatchingEngine is null/empty")]
        public void The_exception_is_thrown_when_text_argument_is_null_or_empty()
        {
            var engine = CreateEngine();
            var exception = Record.Exception(() => engine.GetIndexes(null, "Polly"));

            Assert.NotNull(exception);
            Assert.IsType<ArgumentNullException>(exception);
        }

        [Fact(DisplayName = "The ArgumentNull exception is thrown when the SubText parameter of TextMatchingEngine is null/empty.")]
        public void The_exception_is_thrown_when_subtext_arguments_is_null_or_empty()
        {
            var engine = CreateEngine();
            var exception = Record.Exception(() => engine.GetIndexes(Text, "  "));

            Assert.NotNull(exception);
            Assert.IsType<ArgumentNullException>(exception);
        }


        [Fact(DisplayName = "The ArgumentNull exception is thrown when arguments of TextMatchingEngine are null/empty.")]
        public void The_exception_is_thrown_when_arguments_are_null_or_empty()
        {
            var engine = CreateEngine();
            var exception = Record.Exception(() => engine.GetIndexes(null, "  "));

            Assert.NotNull(exception);
            Assert.IsType<ArgumentNullException>(exception);
        }

        [Fact(DisplayName = "If the subtext is matched against the text, it should return the character position of the begining of each match")]
        public void Return_all_indices()
        {
            var engine = CreateEngine();
            var result = engine.GetIndexes(Text, "Polly").ToList();

            Assert.NotNull(result);

            Assert.Equal<int>(1, result.First());
            Assert.Equal<int>(26, result.Skip(1).First());
            Assert.Equal<int>(51, result.Skip(2).First());
        }

        [Fact(DisplayName = "The case should be ignored when matching the strings")]
        public void Case_insensitive_matching()
        {
            var engine = CreateEngine();
            var result = engine.GetIndexes(Text, "polly").ToList();

            Assert.NotNull(result);

            Assert.Equal<int>(1, result.First());
            Assert.Equal<int>(26, result.Skip(1).First());
            Assert.Equal<int>(51, result.Skip(2).First());
        }

        [Fact(DisplayName = "It shoud return empty list when the character doesn't match with the text.")]
        public void No_match_character()
        {
            var engine = CreateEngine();
            var result = engine.GetIndexes(Text, "X").ToList();

            Assert.NotNull(result);

            Assert.Equal<int>(0, result.Count);
        }

        [Fact(DisplayName = "It shoud return empty list when the word doesn't match with the text.")]
        public void No_match_word()
        {
            var engine = CreateEngine();
            var result = engine.GetIndexes(Text, "Polx").ToList();

            Assert.NotNull(result);

            Assert.Equal<int>(0, result.Count);
        }

        [Fact(DisplayName = "It should return the indexes of all characters (not just a word)")]
        public void Should_Be_Able_Find_Indexes_Of_Characters()
        {
            var engine = CreateEngine();
            var result = engine.GetIndexes(Text, "ll").ToList();

            Assert.NotNull(result);

            AssertCharacterIndexes(result);
        }

        [Fact(DisplayName = "It should return the indexes of all characters (not just a word) even the cases are different.")]
        public void Should_Be_Able_Find_Indexes_Of_Characters_Even_Cases_Are_Different()
        {
            var engine = CreateEngine();
            var result = engine.GetIndexes(Text, "Ll").ToList();

            Assert.NotNull(result);

            AssertCharacterIndexes(result);
        }

        private static void AssertCharacterIndexes(List<int> result)
        {
            Assert.Equal<int>(3, result.First());
            Assert.Equal<int>(28, result.Skip(1).First());
            Assert.Equal<int>(53, result.Skip(2).First());
            Assert.Equal<int>(78, result.Skip(3).First());
            Assert.Equal<int>(82, result.Skip(4).First());
        }
    }
}