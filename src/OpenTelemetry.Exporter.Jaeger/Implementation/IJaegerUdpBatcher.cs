﻿// <copyright file="IJaegerUdpBatcher.cs" company="OpenTelemetry Authors">
// Copyright 2018, OpenTelemetry Authors
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
using System;
using System.Threading;
using System.Threading.Tasks;

namespace OpenTelemetry.Exporter.Jaeger.Implementation
{
    public interface IJaegerUdpBatcher : IDisposable
    {
        Process Process { get; }

        Task<int> AppendAsync(JaegerSpan span, CancellationToken cancellationToken);

        Task<int> CloseAsync(CancellationToken cancellationToken);

        Task<int> FlushAsync(CancellationToken cancellationToken);
    }
}
