import React from 'react'

const BookList = ({book}) => {
  return (
    <div className="grid-item">
      <div className="box flex-column">
        <a href={`/books/${book.ISBN}`}>
          <img src={book.image} className="box-image" alt=""/>
          <p className="title">{book.Title}</p>
          <p className="author">{book.Author}</p>
        </a>
        <div className="price">{book.Price} &euro;</div>
      </div>
    </div>
  )
}

export default BookList