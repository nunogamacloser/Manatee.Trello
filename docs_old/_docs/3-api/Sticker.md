---
title: Sticker
category: API
order: 250
---

Represents a sticker on a card.

**Assembly:** Manatee.Trello.dll

**Namespace:** Manatee.Trello

**Inheritance hierarchy:**

- Object
- Sticker

## Fields

### static string Check

Represents the stock Check sticker.

### static string Clock

Represents the stock Clock sticker.

### static string Frown

Represents the stock Frown sticker.

### static string Heart

Represents the stock Heart sticker.

### static string Huh

Represents the stock Huh sticker.

### static string Laugh

Represents the stock Laugh sticker.

### static string RocketShip

Represents the stock RocketShip sticker.

### static string Smile

Represents the stock Smile sticker.

### static string Star

Represents the stock Star sticker.

### static string ThumbsDown

Represents the stock ThumbsDown sticker.

### static string ThumbsUp

Represents the stock ThumbsUp sticker.

### static string Warning

Represents the stock Warning sticker.

## Properties

### static Sticker.Fields DownloadedFields { get; set; }

Specifies which fields should be downloaded.

### string Id { get; }

Gets the checklist&#39;s ID.

### string ImageUrl { get; }

Gets the URL for the sticker&#39;s image.

### double? Left { get; set; }

Gets or sets the position of the left edge.

### string Name { get; }

Gets the name of the sticker.

### IReadOnlyCollection&lt;[IImagePreview](../IImagePreview#iimagepreview)&gt; Previews { get; }

Gets the collection of previews.

### int? Rotation { get; set; }

Gets or sets the rotation.

#### Remarks

Rotation is clockwise and in degrees.

### double? Top { get; set; }

Gets or sets the position of the top edge.

### int? ZIndex { get; set; }

Gets or sets the z-index.

## Events

### Action&lt;[ISticker](../ISticker#isticker), IEnumerable&lt;string&gt;&gt; Updated

Raised when data on the attachment is updated.

## Methods

### Task Delete(CancellationToken ct = default(CancellationToken))

Deletes the sticker.

**Parameter:** ct

(Optional) A cancellation token for async processing.

#### Remarks

This permanently deletes the sticker from Trello&#39;s server, however, this object will remain in memory and all properties will remain accessible.

### Task Refresh(bool force = False, CancellationToken ct = default(CancellationToken))

Refreshes the sticker data.

**Parameter:** force

Indicates that the refresh should ignore the value in Manatee.Trello.TrelloConfiguration.RefreshThrottle and make the call to the API.

**Parameter:** ct

(Optional) A cancellation token for async processing.

### string ToString()

Returns a string that represents the current object.

**Returns:** A string that represents the current object.
