﻿#region License
/* Copyright (C) 2011 by Scott W. Anderson
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
 */
#endregion

using System;
using System.Net.Mail;
using ActionMailer.Net.Standalone;
using FakeItEasy;
using Xunit;

namespace ActionMailer.Net.Tests.Standalone {
    public class RazorEmailResultTests {
        [Fact]
        public void ConstructorWithNullInterceptorThrows() {
            var mockSender = A.Fake<IMailSender>();

            Assert.Throws<ArgumentNullException>(() => {
                new RazorEmailResult(null, mockSender, new MailMessage(), "View", null, "Path");
            });
        }

        [Fact]
        public void ConstructorWithNullSenderThrows() {
            var mockInterceptor = A.Fake<IMailInterceptor>();

            Assert.Throws<ArgumentNullException>(() => {
                new RazorEmailResult(mockInterceptor, null, new MailMessage(), "View", null, "Path");
            });
        }

        [Fact]
        public void ConstructorWithNullMailMessageThrows() {
            var mockSender = A.Fake<IMailSender>();
            var mockInterceptor = A.Fake<IMailInterceptor>();

            Assert.Throws<ArgumentNullException>(() => {
                new RazorEmailResult(mockInterceptor, mockSender, null, "View", null, "Path");
            });
        }

        [Fact]
        public void ConstructorWithNullViewNameThrows() {
            var mockSender = A.Fake<IMailSender>();
            var mockInterceptor = A.Fake<IMailInterceptor>();

            Assert.Throws<ArgumentNullException>(() => {
                new RazorEmailResult(mockInterceptor, mockSender, new MailMessage(), null, null, "Path");
            });
        }

        [Fact]
        public void ConstructorWithNullViewPathThrows() {
            var mockSender = A.Fake<IMailSender>();
            var mockInterceptor = A.Fake<IMailInterceptor>();

            Assert.Throws<ArgumentNullException>(() => {
                new RazorEmailResult(mockInterceptor, mockSender, new MailMessage(), "View", null, null);
            });
        }
    }
}