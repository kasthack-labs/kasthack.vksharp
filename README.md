VKSharp
=======

###Usage

1. Create VKApi instanse
	```C#
	var api = new VKApi();
	```
2. Get token URL
	```C#
	VKToken.GetOAuthURL( APP_KEY, PERMISSIONS );
	```
3. Make token from response
	```C#
	var token = VKToken.FromRedirectUrl( REDIRECT_URL );
	```
4. Add to Api
	```C#
	api.AddToken(token);
	```
5. Enjoy



### Implemented methods

* Account
	* account.banUser
	* account.getAppPermissions
	* account.getBanned
	* account.getProfileInfo
	* account.setInfo
	* account.setNameInMenu
	* account.setOffline
	* account.setOnline
	* account.setSilenceMode
	* account.unbanUser
	* account.unregisterDevice
* Audio
	* audio.add
	* audio.addAlbum
	* audio.delete
	* audio.deleteAlbum
	* audio.get
	* audio.getById
	* audio.getById
	* audio.getCount
	* audio.getLyrics
	* audio.getUploadServer
	* audio.reorder
	* audio.restore
	* audio.save
	* audio.search
* Auth
	* auth.checkPhone
	* auth.confirm
	* auth.restore
* Board
	* board.closeTopic
	* board.deleteComment
	* board.deleteTopic
	* board.fixTopic
	* board.restoreComment
	* board.unfixTopic
* Database
	* database.getChairs
	* database.getCities
	* database.getCitiesById
	* database.getCountries
	* database.getCountriesById
	* database.getFaculties
	* database.getRegions
	* database.getSchools
	* database.getStreetsById
	* database.getUniversities
* Docs
	* docs.add
	* docs.delete
	* docs.get
	* docs.getById
	* docs.getUploadServer
	* docs.getWallUploadServer
	* docs.save
* Friends
	* friends.add
	* friends.delete
	* friends.deleteAllRequests
	* friends.deleteList
	* friends.get
	* friends.getAppUsers
	* friends.getByPhones
	* friends.getMutual
	* friends.getRecent
	* friends.getSuggestions
* Groups
	* groups.getBanned
	* groups.getById
	* groups.getById
	* groups.getMembers
	* groups.getMembers
	* groups.isMember
	* groups.join
	* groups.leave
	* groups.unbanUser
* Messages
	* messages.addChatUser
	* messages.delete
	* messages.deleteDialog
	* messages.markAsImportant
	* messages.markAsRead
	* messages.removeChatUser
	* messages.restore
* Newsfeed
	* newsfeed.addBan
	* newsfeed.deleteBan
* Notes
	* notes.delete
	* notes.deleteComment
	* notes.restoreComment
* Notifications
	* notifications.markAsViewed
* Pages
	* pages.clearCache
* Photos
	* photos.confirmTag
	* photos.copy
	* photos.createAlbum
	* photos.delete
	* photos.deleteAlbum
	* photos.deleteComment
	* photos.edit
	* photos.editAlbum
	* photos.get
	* photos.get
	* photos.getAlbums
	* photos.getAlbumsCount
	* photos.getAll
	* photos.getChatUploadServer
	* photos.getOwnerPhotoUploadServer
	* photos.getUploadServer
	* photos.makeCover
	* photos.move
	* photos.removeTag
	* photos.reorderAlbums
	* photos.reorderPhotos
	* photos.report
	* photos.reportComment
	* photos.restoreComment
	* photos.save
* Status
	* status.get
	* status.set
* Storage
	* storage.get
	* storage.getKeys
	* storage.set
* Users
	* users.get
	* users.getFollowers
	* users.getNearby
	* users.getSubscriptions
	* users.isAppUser
	* users.report
	* users.search
* Utils
	* utils.checkLink
	* utils.getServerTime
* Video
	* video.delete
	* video.deleteAlbum
	* video.deleteComment
	* video.removeTag
	* video.report
	* video.reportComment
	* video.restoreComment
* Wall
	* wall.delete
	* wall.deleteComment
	* wall.get
	* wall.getById
	* wall.getById
	* wall.pin
	* wall.reportComment
	* wall.reportPost
	* wall.repost
	* wall.restore
	* wall.restoreComment
	* wall.unpin

[![Flattr this git repo](http://api.flattr.com/button/flattr-badge-large.png)](https://flattr.com/submit/auto?user_id=kasthack&url=https://github.com/kasthack/VKSharp&title=VKSharp&language=&tags=github&category=software)
