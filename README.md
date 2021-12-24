# Playlist
 Web-Programlama Proje

 Proje amacı kullanıcıların sitede kendilerine ait müzik çalma liste oluşturup herkesle bu listeyi paylaşa bilmek. Her kullanıcı istenilen kadar çalma listesi (Playlist) oluşturup ve içeriğine isteniler kadar müzik ekleye bilir. 
Projede User, Playlist, Music modelleri yer buluyor.

User model property: string Name, string LastName, ICollection Playlist
Playlist model property: string Name, int UserID, User user
Music model property: int MusicID, string Album, string Name, string Artist, string RealiseDate, string Link

Projede Authorization Authentication kavramları İdentityUser sınıfı yardımcılığıyla gerçekleştirilmiş.
Login işlemi gerçekleştirildiğinde kullanıcı üst Nav-bar menüsünde Playlists ve Musics menülerine erişi biliyor.

Projede UserRole ayrımı olarak admin kullanıcısı bulunuyor.
