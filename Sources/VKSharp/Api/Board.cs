using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VKSharp.Core.Entities;
using VKSharp.Data.Request;
using VKSharp.Helpers;
using VKSharp.Helpers.PrimitiveEntities;

namespace VKSharp {
    public partial class VKApi {
        public async Task<StructEntity<bool>> BoardDeleteTopicAsync(uint groupId, uint topicId) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "board.deleteTopic",
                Parameters = new Dictionary<string, string> {
                    { "group_id", groupId.ToNCString() },
                    { "topic_id", topicId.ToNCString() },
                }
            };
            if (!this.IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = this.CurrenToken;
            return (await this._executor.ExecAsync(req)).Data.FirstOrDefault();
        }
        public async Task<StructEntity<bool>> BoardDeleteCommentAsync(uint groupId, uint topicId, uint comment_id) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "board.deleteComment",
                Parameters = new Dictionary<string, string> {
                    { "group_id", groupId.ToNCString() },
                    { "topic_id", topicId.ToNCString() },
                    { "comment_id", comment_id.ToNCString() }
                }
            };
            if (!this.IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = this.CurrenToken;
            return (await this._executor.ExecAsync(req)).Data.FirstOrDefault();
        }
        public async Task<StructEntity<bool>> BoardRestoreCommentAsync(uint groupId, uint topicId, uint comment_id) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "board.restoreComment",
                Parameters = new Dictionary<string, string> {
                    { "group_id", groupId.ToNCString() },
                    { "topic_id", topicId.ToNCString() },
                    { "comment_id", comment_id.ToNCString() }
                }
            };
            if (!this.IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = this.CurrenToken;
            return (await this._executor.ExecAsync(req)).Data.FirstOrDefault();
        }
        
        public async Task<StructEntity<bool>> BoardCloseTopicAsync(uint groupId, uint topicId) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "board.closeTopic",
                Parameters = new Dictionary<string, string> {
                    { "group_id", groupId.ToNCString() },
                    { "topic_id", topicId.ToNCString() },
                }
            };
            if (!this.IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = this.CurrenToken;
            return (await this._executor.ExecAsync(req)).Data.FirstOrDefault();
        }
        public async Task<StructEntity<bool>> BoardFixTopicAsync(uint groupId, uint topicId) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "board.fixTopic",
                Parameters = new Dictionary<string, string> {
                    { "group_id", groupId.ToNCString() },
                    { "topic_id", topicId.ToNCString() },
                }
            };
            if (!this.IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = this.CurrenToken;
            return (await this._executor.ExecAsync(req)).Data.FirstOrDefault();
        }
        public async Task<StructEntity<bool>> BoardUnfixTopicAsync(uint groupId, uint topicId) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "board.unfixTopic",
                Parameters = new Dictionary<string, string> {
                    { "group_id", groupId.ToNCString() },
                    { "topic_id", topicId.ToNCString() },
                }
            };
            if (!this.IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = this.CurrenToken;
            return (await this._executor.ExecAsync(req)).Data.FirstOrDefault();
        }
        
    }
}
