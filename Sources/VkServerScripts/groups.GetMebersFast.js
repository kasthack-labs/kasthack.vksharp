/*
	Bulk group.GetMembers
	
	returns ordered array of ids;
*/
var id = parseInt(Args.id);
var cnt = parseInt(Args.count);
var off = parseInt(Args.offset);
var maxchunk = 500;

var ret = [];
var retlog = "";

while(cnt>0){
	var count = maxchunk;
	if (cnt < maxchunk) count = cnt;
	retlog = retlog + "offset: "+ off+" count:"+count+"\r\n";
	ret = ret + API.groups.getMembers({"group_id":id, "count": count, "offset": off}).items;
	
	cnt = cnt - count;
	off = off + count;
}
return ret;