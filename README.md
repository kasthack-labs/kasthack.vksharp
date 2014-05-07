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
	* account.getBanned
	* account.setOffline
	* account.setOnline
	* account.unregisterDevice
	* account.banUser
	* account.unbanUser
	* account.setInfo
* Audios
	* audios.add
	* audios.addAlbum
	* audios.delete
	* audios.deleteAlbum
	* audios.get
	* audios.getCount
	* audios.getLyrics
	* audios.getUploadServer
	* audios.reorder
* Auth
	* auth.checkPhone
* Database [*^getSchoolClasses]
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
	* groups.isMember
	* groups.join
	* groups.leave
	* groups.unbanUser
* Board
	* board.deleteTopic
	* board.deleteComment
	* board.restoreComment
	* board.closeTopic
	* board.fixTopic
	* board.unfixTopic
* Messages
	* messages.delete
	* messages.deleteDialog
	* messages.restore
	* messages.removeChatUser
	* messages.addChatUser
	* messages.markAsRead
	* messages.markAsImportant
* Notes
	* notes.delete
	* notes.deleteComment
	* notes.restoreComment
* Photos
	* photos.confirmTag
	* photos.copy
	* photos.delete
	* photos.deleteAlbum
	* photos.deleteComment
	* photos.edit
	* photos.getAlbumCount
	* photos.getProfileUploadServer
	* photos.getUploadServer
	* photos.makeCover
	* photos.move
	* photos.removeTag
	* photos.reorderAlbums
	* photos.reorderPhotos
	* photos.report
	* photos.reportComment
	* photos.restoreComment
* Status
	* status.set
* Storage [x]
	* storage.get
	* storage.getKeys
	* storage.set
* User	[*^getSubscriptions]
	* users.isAppUser
	* users.get
	* users.getFollowers
	* users.report
	* users.search
* Utils [*^resolveScreenName]
	* utils.checkLink
	* utils.getServerTime
* Videos
	* videos.delete
	* videos.deleteAlbum
	* videos.deleteComment
	* videos.removeTag
	* videos.report
	* videos.reportComment
	* videos.restoreComment
* Wall
	* wall.delete
	* wall.deleteComment
	* wall.reportComment
	* wall.reportPost
	* wall.restore
	* wall.restoreComment