using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VKSharp.Data.Request;
using VKSharp.Helpers;
using VKSharp.Helpers.PrimitiveEntities;

namespace VKSharp {
    public partial class VKApi {
        public async Task BoardCloseTopicAsync(uint groupId, uint topicId) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "board.closeTopic",
                Parameters = new Dictionary<string, string> {
                    { "group_id", groupId.ToNCString() },
                    { "topic_id", topicId.ToNCString() },
                }
            };
            if (!IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = CurrenToken;
            await _executor.ExecAsync(req);
        }
        public async Task BoardDeleteCommentAsync(uint groupId, uint topicId, uint comment_id) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "board.deleteComment",
                Parameters = new Dictionary<string, string> {
                    { "group_id", groupId.ToNCString() },
                    { "topic_id", topicId.ToNCString() },
                    { "comment_id", comment_id.ToNCString() }
                }
            };
            if (!IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = CurrenToken;
            await _executor.ExecAsync(req);
        }
        public async Task BoardDeleteTopicAsync(uint groupId, uint topicId) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "board.deleteTopic",
                Parameters = new Dictionary<string, string> {
                    { "group_id", groupId.ToNCString() },
                    { "topic_id", topicId.ToNCString() },
                }
            };
            if (!IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = CurrenToken;
            await _executor.ExecAsync(req);
        }
        public async Task BoardFixTopicAsync(uint groupId, uint topicId) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "board.fixTopic",
                Parameters = new Dictionary<string, string> {
                    { "group_id", groupId.ToNCString() },
                    { "topic_id", topicId.ToNCString() },
                }
            };
            if (!IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = CurrenToken;
            await _executor.ExecAsync(req);
        }
        public async Task BoardRestoreCommentAsync(uint groupId, uint topicId, uint comment_id) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "board.restoreComment",
                Parameters = new Dictionary<string, string> {
                    { "group_id", groupId.ToNCString() },
                    { "topic_id", topicId.ToNCString() },
                    { "comment_id", comment_id.ToNCString() }
                }
            };
            if (!IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = CurrenToken;
            await _executor.ExecAsync(req);
        }
        public async Task BoardUnfixTopicAsync(uint groupId, uint topicId) {
            var req = new VKRequest<StructEntity<bool>> {
                MethodName = "board.unfixTopic",
                Parameters = new Dictionary<string, string> {
                    { "group_id", groupId.ToNCString() },
                    { "topic_id", topicId.ToNCString() },
                }
            };
            if (!IsLogged)
                throw new InvalidOperationException("This method requires auth!");
            req.Token = CurrenToken;
            await _executor.ExecAsync(req);
        }
    }
}
