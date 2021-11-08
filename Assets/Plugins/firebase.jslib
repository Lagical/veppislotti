mergeInto(LibraryManager.library, {
     getAle: function(alennus){
        var stringAle = UTF8ToString(alennus)
        console.log(stringAle);
        setAleInJs(stringAle);
    }
});