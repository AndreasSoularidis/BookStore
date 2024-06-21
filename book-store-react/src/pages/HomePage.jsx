import React from 'react'
import Hero from '../components/Hero'
import BookListings from '../components/BookListings'

const HomePage = () => {
  return (
    <>
     <Hero title="Η ΜΕΓΑΛΥΤΕΡΗ ΓΚΑΜΑ ΒΙΒΛΙΩΝ ΣΤΟΝ ΚΟΣΜΟ"/>
     <BookListings />
   </>
  )
}

export default HomePage