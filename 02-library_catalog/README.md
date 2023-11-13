# Library Catalog System

## Objective

This programming task involves creating a simple library catalog system in C#. The system will manage a collection of books and media items, like DVDs and CDs, utilizing object-oriented programming concepts.

## Requirements

### Library Class

The `Library` class will represent the core of the system with the following properties and methods:

#### Properties

- `Name`: A string indicating the name of the library.
- `Address`: A string detailing the address of the library.
- `Books`: A list storing instances of the `Book` class.
- `MediaItems`: A list storing instances of the `MediaItem` class.

#### Methods

- `AddBook(Book book)`: Adds a new book to the library.
- `RemoveBook(Book book)`: Removes a book from the library.
- `AddMediaItem(MediaItem item)`: Adds a new media item to the library.
- `RemoveMediaItem(MediaItem item)`: Removes a media item from the library.
- `PrintCatalog()`: Outputs the complete list of books and media items.

### Book Class

The `Book` class will represent individual books with the following properties:

- `Title`: The title of the book.
- `Author`: The author's name.
- `ISBN`: The International Standard Book Number.
- `PublicationYear`: The year the book was published.

### MediaItem Class

The `MediaItem` class will represent media items, such as DVDs and CDs, with these properties:

- `Title`: The title of the item.
- `MediaType`: The type of the media item (e.g., 'DVD', 'CD').
- `Duration`: The playtime duration in minutes.

Constructors and methods should be implemented to allow proper manipulation of these classes' instances.

### Main Method

The `Main` method should:

- Create an instance of `Library`.
- Add a variety of `Book` and `MediaItem` objects to the library.
- Invoke the `PrintCatalog()` method to display the library's contents.

### User Interaction

The program should:

- Handle user input robustly.
- Provide clear error messages for invalid operations.
