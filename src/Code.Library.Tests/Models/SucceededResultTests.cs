﻿using System;

namespace Code.Library.Tests.Models
{
    using Library.Models;

    using Shouldly;

    using Xunit;

    public class SucceededResultTests
    {
        #region Public Methods

        [Fact]
        public void Can_create_a_generic_version()
        {
            var myClass = new MyClass();

            Result<MyClass> result = Result.Ok(myClass);

            result.IsFailure.ShouldBe(false);
            result.IsSuccess.ShouldBe(true);
            result.Value.ShouldBe(myClass);
        }

        [Fact]
        public void Can_create_a_non_generic_version()
        {
            Result result = Result.Ok();

            result.IsFailure.ShouldBe(false);
            result.IsSuccess.ShouldBe(true);
        }

        [Fact]
        public void Cannot_create_without_Value()
        {
            Action action = () => { Result.Ok((MyClass)null); };

            action.ShouldThrow<ArgumentNullException>(); ;
        }

        #endregion Public Methods

        //[Fact]
        //public void Cannot_access_Error_non_generic_version()
        //{
        //    Result result = Result.Ok();

        //    Action action = () =>
        //    {
        //        string error = result.Error;
        //    };

        //    action.ShouldThrow<InvalidOperationException>();
        //}

        //[Fact]
        //public void Cannot_access_Error_generic_version()
        //{
        //    Result<MyClass> result = Result.Ok(new MyClass());

        //    Action action = () =>
        //    {
        //        string error = result.Error;
        //    };

        //    action.ShouldThrow<InvalidOperationException>();
        //}

        #region Private Classes

        private class MyClass
        {
        }

        #endregion Private Classes
    }
}