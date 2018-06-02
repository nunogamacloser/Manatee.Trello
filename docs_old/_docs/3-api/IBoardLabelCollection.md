---
title: IBoardLabelCollection
category: API
order: 62
---

A collection of labels for boards.

**Assembly:** Manatee.Trello.dll

**Namespace:** Manatee.Trello

**Inheritance hierarchy:**

- IBoardLabelCollection

## Methods

### Task&lt;[ILabel](../ILabel#ilabel)&gt; Add(string name, LabelColor? color, CancellationToken ct = default(CancellationToken))

Adds a label to the collection.

**Parameter:** name

The name of the label.

**Parameter:** color

The color of the label to add.

**Parameter:** ct

(Optional) A cancellation token for async processing.

**Returns:** The Manatee.Trello.ILabel generated by Trello.

### void Filter(LabelColor labelColor)

Adds a filter to the collection.

**Parameter:** labelColor

The filter value.
