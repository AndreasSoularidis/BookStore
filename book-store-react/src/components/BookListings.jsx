import React from 'react'
import books from '../../books.json'
import BookList from './BookList';

const JobListings = () => {
  const recentBooks = books.slice(0, 6);
  return (
    <section>
      <div className="container">
        <h2 className="text-center text-medium"><span className="text-highlight">Πρόσφατες Κυκλοφορίες</span></h2>
        <div className="grid-container">
          {recentBooks.map((book) => (
            <BookList key={book.ISBN} book = {book} />
          ))}
        
          
        </div>
      </div>
    </section>
  )
}

export default JobListings