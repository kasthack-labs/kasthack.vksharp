namespace kasthack.vksharp.DataTypes.ResponseEntities {
    public class AddAlbum {
        public int AlbumId { get; set; }

        public static implicit operator int( AddAlbum album ) => album.AlbumId;
        public static implicit operator AddAlbum(int albumId) => new AddAlbum() {AlbumId = albumId};
    }
}
