#region Corpspace© Apache-2.0
// Copyright © 2023 Sultan Soltanov. All rights reserved.
// Author: Sultan Soltanov
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//        http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
#endregion

using Newtonsoft.Json;

namespace GptSharp.Applications.Dto;

public class OpenAIAPIChoice
{
    [JsonProperty("text")]
    public string Text { get; set; }

    [JsonProperty("index")]
    public int Index { get; set; }

    [JsonProperty("logprobs")]
    public object LogProbs { get; set; }

    [JsonProperty("finish_reason")]
    public string FinishReason { get; set; }
}