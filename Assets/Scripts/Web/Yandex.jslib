mergeInto(LibraryManager.library, {
  GetLanguageExtern: function () {
    var lang = ysdk.environment.i18n.lang;
    var bufferSize = lengthBytesUTF8(lang) + 1;
    var buffer = _malloc(bufferSize);
    stringToUTF8(lang, buffer, bufferSize);
    return buffer;
  },
  SetLeaderBoardExtern: function (value)
  {
    ysdk.getLeaderboards()
    .then(lb => {
      lb.setLeaderboardScore('Score', value);
    });
  },
  ReviveExtern: function ()
  {
    ysdk.adv.showRewardedVideo({
      callbacks: {
        onRewarded: () => {
          myGameInstance.SendMessage('Management', 'Revive');
        }
      }
    })
  },
  ShowAdExtern: function ()
  {
    ysdk.adv.showFullscreenAdv({callbacks:{}});
  }
});